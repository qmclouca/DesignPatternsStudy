namespace Decorator
{
    public class Decorator: ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }

        public override void Exibe()
        {
            itemBiblioteca.Exibe();
        }
    }
}
