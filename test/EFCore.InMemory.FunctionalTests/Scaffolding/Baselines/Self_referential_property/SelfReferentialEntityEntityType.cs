// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class SelfReferentialEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+SelfReferentialEntity",
                typeof(CompiledModelInMemoryTest.SelfReferentialEntity),
                baseEntityType,
                propertyCount: 2,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(CompiledModelInMemoryTest.SelfReferentialEntity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.SelfReferentialEntity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            id.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                clrType: typeof(long),
                jsonValueReaderWriter: JsonInt64ReaderWriter.Instance);

            var collection = runtimeEntityType.AddProperty(
                "Collection",
                typeof(CompiledModelInMemoryTest.SelfReferentialProperty),
                propertyInfo: typeof(CompiledModelInMemoryTest.SelfReferentialEntity).GetProperty("Collection", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.SelfReferentialEntity).GetField("<Collection>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueConverter: new CompiledModelInMemoryTest.SelfReferentialPropertyValueConverter());
            collection.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<CompiledModelInMemoryTest.SelfReferentialProperty>(
                    (CompiledModelInMemoryTest.SelfReferentialProperty v1, CompiledModelInMemoryTest.SelfReferentialProperty v2) => object.Equals(v1, v2),
                    (CompiledModelInMemoryTest.SelfReferentialProperty v) => v.GetHashCode(),
                    (CompiledModelInMemoryTest.SelfReferentialProperty v) => v),
                keyComparer: new ValueComparer<CompiledModelInMemoryTest.SelfReferentialProperty>(
                    (CompiledModelInMemoryTest.SelfReferentialProperty v1, CompiledModelInMemoryTest.SelfReferentialProperty v2) => object.Equals(v1, v2),
                    (CompiledModelInMemoryTest.SelfReferentialProperty v) => v.GetHashCode(),
                    (CompiledModelInMemoryTest.SelfReferentialProperty v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                converter: new ValueConverter<CompiledModelInMemoryTest.SelfReferentialProperty, string>(
                    (CompiledModelInMemoryTest.SelfReferentialProperty v) => null,
                    (string v) => null),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CompiledModelInMemoryTest.SelfReferentialProperty, string>(
                    JsonStringReaderWriter.Instance,
                    new ValueConverter<CompiledModelInMemoryTest.SelfReferentialProperty, string>(
                        (CompiledModelInMemoryTest.SelfReferentialProperty v) => null,
                        (string v) => null)));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}