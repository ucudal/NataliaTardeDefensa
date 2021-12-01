namespace Ucu.Poo.Defense
{
    public abstract class Visitor
{
    public string Content
    {
        get
        {
            return this.ContentBuilder.ToString();
        }
    }

    protected StringBuilder ContentBuilder { get; } = new StringBuilder();

    public abstract void Visit(Offer offer);

    public abstract void Visit(Offeritem offeritem);

    public abstract void Visit(Residue name);
}