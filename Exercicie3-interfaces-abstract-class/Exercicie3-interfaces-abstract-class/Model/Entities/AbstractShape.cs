using Exercicie3_interfaces_abstract_class.Model.Enums;


namespace Exercicie3_interfaces_abstract_class.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}