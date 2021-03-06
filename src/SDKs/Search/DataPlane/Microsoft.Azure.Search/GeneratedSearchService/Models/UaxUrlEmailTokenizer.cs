// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tokenizes urls and emails as one token. This tokenizer is implemented
    /// using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/UAX29URLEmailTokenizer.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.UaxUrlEmailTokenizer")]
    public partial class UaxUrlEmailTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the UaxUrlEmailTokenizer class.
        /// </summary>
        public UaxUrlEmailTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the UaxUrlEmailTokenizer class.
        /// </summary>
        /// <param name="name">The name of the tokenizer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="maxTokenLength">The maximum token length. Default is
        /// 255. Tokens longer than the maximum length are split. The maximum
        /// token length that can be used is 300 characters.</param>
        public UaxUrlEmailTokenizer(string name, int? maxTokenLength = default(int?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Default is 255. Tokens
        /// longer than the maximum length are split. The maximum token length
        /// that can be used is 300 characters.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MaxTokenLength > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxTokenLength", 300);
            }
        }
    }
}

