﻿using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModuleDescribed<ISerializeModuleDescription>, ISerializeModule
    {
        public ISerializerProvider Provider { get; }

        public SerializeModule(IApplication application, ISerializeModuleDescription description, ISerializerProvider provider = null) : base(application, description)
        {
            Provider = provider ?? new SerializerProvider();
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            foreach (KeyValuePair<string, ISerializerBuilder> pair in Description.Serializers)
            {
                ISerializerBuilder builder = pair.Value;
                ISerializer serializer = builder.Build();

                Provider.Add(builder.Name, serializer);
            }
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            Provider.Clear();
        }

        public ISerializer<byte[]> GetDefaultBytesSerializer()
        {
            ISerializerBuilder builder = GetSerializerBuilder(Description.DefaultBytesSerializeId);
            ISerializer<byte[]> serializer = Provider.Get<byte[]>(builder.Name);

            return serializer;
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
            ISerializerBuilder builder = GetSerializerBuilder(Description.DefaultTextSerializerId);
            ISerializer<string> serializer = Provider.Get<string>(builder.Name);

            return serializer;
        }

        public ISerializerBuilder GetSerializerBuilder(string id)
        {
            return TryGetSerializerBuilder(id, out ISerializerBuilder builder) ? builder : throw new ArgumentException($"Serializer builder not found by the specified id: '{id}'.");
        }

        public bool TryGetSerializerBuilder(string id, out ISerializerBuilder builder)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("Value cannot be null or empty.", nameof(id));

            return Description.Serializers.TryGetValue(id, out builder);
        }
    }
}
