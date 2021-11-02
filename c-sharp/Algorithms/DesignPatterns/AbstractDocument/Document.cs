using System;
using System.Collections.Generic;

namespace DesignPatterns.AbstractDocument
{
    public interface Document
    {
        void put(string key, object value);
        
        object get(string key);
    }

    public interface HasType : Document
    {
        string? getType()
        {
            return get("Type").ToString();
        }
    }

    public interface HasModel : Document
    {
        string? getModel()
        {
            return get("Model").ToString();
        }
    }

    public interface HasPrice : Document
    {
        string? getPrice()
        {
            return get("Price").ToString();
        }
    }

}

