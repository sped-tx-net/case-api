using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.OpenApi.Models;
using SharpYaml.Tokens;

namespace System.Text.CodeGeneration
{
    internal static class OpenApiDocumentExtensions
    {
        public static List<TaggedOpenApiOperations> GetTaggedOperations(this OpenApiDocument source)
        {
            
            var retVal = new List<TaggedOpenApiOperations>();
            foreach (var tag in source.Tags)
            {
                var operations = GetTagOperations(source.Paths, tag.Name);
                retVal.Add(new TaggedOpenApiOperations(tag, operations));
            }

            return retVal;
        }

        private static List<OpenApiOperation> GetTagOperations(OpenApiPaths paths, string tagName)
        {
            List<OpenApiOperation> list = new List<OpenApiOperation>();
            foreach (var operation in paths.SelectMany(x => x.Value.Operations.Select(y => y.Value)))
            {
                foreach (var operationTag in operation.Tags)
                {
                    if (operationTag.Name.Equals(tagName))
                        list.Add(operation);

                    var returnType = operation.Responses["200"].Content["application/json"].Schema.Reference.Id;
                }
            }
            return list;
        }

        private static OpenApiTags GetDocumentTags(OpenApiDocument document)
        {
            var tags = new OpenApiTags();
            foreach(var tag in document.Tags)
            {
                tags.AddTag(tag);
            }
            foreach (var operation in document.Paths.SelectMany(
                x => x.Value.Operations.Select(
                    y => y.Value)))
            {
                foreach (var operationTag in operation.Tags)
                {
                    var tagName = operationTag.Name;
                    var taggedOperation = tags[tagName];
                    if (taggedOperation != null)
                    {
                        taggedOperation.Operations.Add(operation);
                    }
                }
            }
            return tags;
        }
    }

    public class TaggedOpenApiOperations
    {
        public TaggedOpenApiOperations(OpenApiTag tag, List<OpenApiOperation> operations = null)
        {
            Tag = tag;
            Operations = operations ?? new List<OpenApiOperation>();
        }

        public OpenApiTag Tag { get; }

        public List<OpenApiOperation> Operations { get; }
    }

    public class OpenApiTags : HashSet<TaggedOpenApiOperations>
    {
        public OpenApiTags(): base(new TagComparer())
        {
        }

        public bool AddTag(OpenApiTag tag)
        {
            return Add(new TaggedOpenApiOperations(tag));
        }

        public TaggedOpenApiOperations this[string tagName]
        {
            get
            {
                foreach (var tag in this)
                    if (StringComparer.CurrentCultureIgnoreCase.Equals(tag.Tag.Name, tagName))
                        return tag;
                return null;
            }
        }

        private class TagComparer : IEqualityComparer<TaggedOpenApiOperations>
        {
            public bool Equals(TaggedOpenApiOperations x, TaggedOpenApiOperations y)
{
                return StringComparer.CurrentCultureIgnoreCase.Equals(x.Tag.Name, y.Tag.Name);
            }

            public int GetHashCode([DisallowNull] TaggedOpenApiOperations obj)
            {
                return obj.Tag.Name.GetHashCode();
            }
        }
    }
}
