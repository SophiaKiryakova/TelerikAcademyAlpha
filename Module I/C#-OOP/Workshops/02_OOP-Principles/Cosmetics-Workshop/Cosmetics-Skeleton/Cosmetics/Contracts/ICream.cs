namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    public interface ICream
    {
        string Name { get; }

        string Brand { get; }

        decimal Price { get; }

        GenderType Gender { get; }

        ScentType Scent { get; }

        string Print();
    }
}