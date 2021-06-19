using Microsoft.ML;
using Microsoft.ML.Data;
using System;

namespace MyMachineLearning
{
    public class MLProgram
    {
        public static void Run()
        {
            MLContext mLContext = new MLContext(seed: 1);

            IDataView trainingDataView = mLContext.Data.LoadFromTextFile<ModelInput>(
                path: @"C:\Temp\MLTest.csv",
                hasHeader: true,
                separatorChar: ';',
                allowQuoting: true,
                allowSparse: false);

            //extract features and add algorithm
            IEstimator<ITransformer> trainingPipeline =
                mLContext.Transforms.Text.FeaturizeText(
                    outputColumnName: "Features",
                    inputColumnName: nameof(ModelInput.FeatureColumn))
                .Append(
                    mLContext.BinaryClassification.Trainers.SdcaLogisticRegression(
                        labelColumnName: "Label",
                        featureColumnName: "Features")
                    );

            //Train and return model
            ITransformer model = trainingPipeline.Fit(trainingDataView);

            //Evaluate model
            var metrics = mLContext.BinaryClassification.CrossValidateNonCalibrated(
                trainingDataView, trainingPipeline,
                numberOfFolds: 5,
                labelColumnName: "Features");

            //Try model (predict outcome)
            PredictionEngine<ModelInput, ModelOutput> predictionFunction =
                mLContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

            var sampleInput = new ModelInput { FeatureColumn = "sampleFeature" };
            var result = predictionFunction.Predict(sampleInput);
            Console.WriteLine("Result: " + result.Prediction);

        }
    }

    internal class ModelOutput
    {
        public string Prediction { get; set; }
    }

    public class ModelInput
    {

        [ColumnName("Label"), LoadColumn(0)]
        public string LabelColumn { get; set; }

        [ColumnName("Features"), LoadColumn(1)]
        public string FeatureColumn { get; set; }
    }
}
