using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyWPF.MVVM
{
    //The Model-View-ViewModel Design Pattern

    //Model-View-Presenter (MVP) pattern
    //Has enjoyed popularity on various UI programming platforms.
    //MVP is a variation of the Model-View-Controller pattern, which has been around for decades.
    //Here is a simplified explanation:
    //What you see on the screen is the View,
    //the data it displays is the model,
    //and the Presenter hooks the two together.
    //The view relies on a Presenter to populate it with model data, react to user input, provide input validation

    // Presentation Model (PM)
    // Similar to MVP in that it separates a view from its behavior and state.
    // An abstraction of a view is created, called the Presentation Model.
    // A view, then, becomes merely a rendering of a Presentation Model.

    //MVVM is identical to PM,
    //in that both patterns feature an abstraction of a View,
    //which contains a View's state and behavior.
    //standardized way to leverage core features of WPF to simplify the creation of user interfaces.

    //Unlike the Presenter in MVP, a ViewModel does not need a reference to a view.
    //The view binds to properties on a ViewModel,
    //which exposes data contained in model objects and other state specific to the view.
    //The bindings between view and ViewModel are simple to construct because
    //a ViewModel object is set as the DataContext of a view.

    //The ViewModel, never the View, performs all modifications made to the model data.
    public abstract class _MyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }





}


