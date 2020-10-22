﻿using System.Collections.Generic;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModuleDescription : ISerializeModuleDescription
    {
        public string DefaultBytesSerializeId { get; set; }
        public string DefaultTextSerializerId { get; set; }
        public Dictionary<string, ISerializerBuilder> Serializers { get; } = new Dictionary<string, ISerializerBuilder>();

        IReadOnlyDictionary<string, ISerializerBuilder> ISerializeModuleDescription.Serializers { get { return Serializers; } }
    }
}
