using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=softwaredev2025;AccountKey=xxx;EndpointSuffix=core.windows.net";
string containerName = "jani-test";

// Create a BlobServiceClient object 
Console.WriteLine("Starting the Azure Blob storage demo...");
var blobServiceClient = new BlobServiceClient(connectionString);

// Create the container and return a container client object
BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
Console.WriteLine("Container has been created.");

string blobData = "Hello World from a blob!";
BinaryData data = new(blobData);
containerClient.UploadBlob("my-data.txt", data);
Console.WriteLine("Blob uploaded!");
