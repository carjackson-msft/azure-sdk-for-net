// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Azure Data Lake Storage Gen2 storage. </summary>
    public partial class AzureBlobFSDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureBlobFSDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AzureBlobFSDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            DatasetType = "AzureBlobFSFile";
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobFSDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="folderPath"> The path of the Azure Data Lake Storage Gen2 storage. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> The name of the Azure Data Lake Storage Gen2. Type: string (or Expression with resultType string). </param>
        /// <param name="format">
        /// The format of the Azure Data Lake Storage Gen2 storage.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DatasetAvroFormat"/>, <see cref="DatasetJsonFormat"/>, <see cref="DatasetOrcFormat"/>, <see cref="DatasetParquetFormat"/> and <see cref="DatasetTextFormat"/>.
        /// </param>
        /// <param name="compression"> The data compression method used for the blob storage. </param>
        internal AzureBlobFSDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, DatasetStorageFormat format, DatasetCompression compression) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            FolderPath = folderPath;
            FileName = fileName;
            Format = format;
            Compression = compression;
            DatasetType = datasetType ?? "AzureBlobFSFile";
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobFSDataset"/> for deserialization. </summary>
        internal AzureBlobFSDataset()
        {
        }

        /// <summary> The path of the Azure Data Lake Storage Gen2 storage. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FolderPath { get; set; }
        /// <summary> The name of the Azure Data Lake Storage Gen2. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileName { get; set; }
        /// <summary>
        /// The format of the Azure Data Lake Storage Gen2 storage.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DatasetAvroFormat"/>, <see cref="DatasetJsonFormat"/>, <see cref="DatasetOrcFormat"/>, <see cref="DatasetParquetFormat"/> and <see cref="DatasetTextFormat"/>.
        /// </summary>
        public DatasetStorageFormat Format { get; set; }
        /// <summary> The data compression method used for the blob storage. </summary>
        public DatasetCompression Compression { get; set; }
    }
}
