﻿using System;

namespace MyCouch.Rich.Serialization.Conventions
{
    public class DocTypeSerializationConvention : IDocTypeSerializationConvention
    {
        public string PropertyName
        {
            get { return "$doctype"; }
        }

        public Func<Type, string> Convention { get; private set; }

        public DocTypeSerializationConvention()
        {
            Convention = t => t.Name.ToLower();
        }
    }
}