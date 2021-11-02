using System.Collections.Generic;

namespace DesignPatterns.AbstractDocument
{
    public class Car: AbstractDocument, HasModel, HasPrice, HasType 
    {
        public Car(Dictionary<string, object> properties) : base(properties)
        {
        }
    }
}