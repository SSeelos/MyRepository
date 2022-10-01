namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Behavioral.Mediator
{
    public abstract class _Component
    {
        protected IMyMediator _mediator;
        public _Component(IMyMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
