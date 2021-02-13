<a name='assembly'></a>
# Messaging.Core

## Contents

- [AssemblyType](#T-Messaging-Resolvers-AssemblyType 'Messaging.Resolvers.AssemblyType')
  - [Caller](#F-Messaging-Resolvers-AssemblyType-Caller 'Messaging.Resolvers.AssemblyType.Caller')
  - [EntryHost](#F-Messaging-Resolvers-AssemblyType-EntryHost 'Messaging.Resolvers.AssemblyType.EntryHost')
  - [Library](#F-Messaging-Resolvers-AssemblyType-Library 'Messaging.Resolvers.AssemblyType.Library')
- [CdaValidator](#T-Messaging-Validators-CdaValidator 'Messaging.Validators.CdaValidator')
  - [#ctor(externalResolver)](#M-Messaging-Validators-CdaValidator-#ctor-Messaging-Resolvers-ResourceResolver- 'Messaging.Validators.CdaValidator.#ctor(Messaging.Resolvers.ResourceResolver)')
  - [Create(externalAssembly)](#M-Messaging-Validators-CdaValidator-Create-System-Reflection-Assembly- 'Messaging.Validators.CdaValidator.Create(System.Reflection.Assembly)')
  - [Create(folder)](#M-Messaging-Validators-CdaValidator-Create-System-String- 'Messaging.Validators.CdaValidator.Create(System.String)')
  - [Validate(inputXml,templateSchemaName,genericCdaSchemaName)](#M-Messaging-Validators-CdaValidator-Validate-System-String,System-String,System-String- 'Messaging.Validators.CdaValidator.Validate(System.String,System.String,System.String)')
- [DirectoryResourceResolver](#T-Messaging-Resolvers-DirectoryResourceResolver 'Messaging.Resolvers.DirectoryResourceResolver')
  - [#ctor(path)](#M-Messaging-Resolvers-DirectoryResourceResolver-#ctor-System-String- 'Messaging.Resolvers.DirectoryResourceResolver.#ctor(System.String)')
  - [ResourceList](#P-Messaging-Resolvers-DirectoryResourceResolver-ResourceList 'Messaging.Resolvers.DirectoryResourceResolver.ResourceList')
  - [ResourceSourceName](#P-Messaging-Resolvers-DirectoryResourceResolver-ResourceSourceName 'Messaging.Resolvers.DirectoryResourceResolver.ResourceSourceName')
  - [GetResourceContent(resourceName)](#M-Messaging-Resolvers-DirectoryResourceResolver-GetResourceContent-System-String- 'Messaging.Resolvers.DirectoryResourceResolver.GetResourceContent(System.String)')
- [EmbeddedResourceResolver](#T-Messaging-Resolvers-EmbeddedResourceResolver 'Messaging.Resolvers.EmbeddedResourceResolver')
  - [#ctor(resourceAssembly)](#M-Messaging-Resolvers-EmbeddedResourceResolver-#ctor-System-Reflection-Assembly- 'Messaging.Resolvers.EmbeddedResourceResolver.#ctor(System.Reflection.Assembly)')
  - [ResourceList](#P-Messaging-Resolvers-EmbeddedResourceResolver-ResourceList 'Messaging.Resolvers.EmbeddedResourceResolver.ResourceList')
  - [ResourceSourceName](#P-Messaging-Resolvers-EmbeddedResourceResolver-ResourceSourceName 'Messaging.Resolvers.EmbeddedResourceResolver.ResourceSourceName')
  - [Create(assemblyType)](#M-Messaging-Resolvers-EmbeddedResourceResolver-Create-Messaging-Resolvers-AssemblyType- 'Messaging.Resolvers.EmbeddedResourceResolver.Create(Messaging.Resolvers.AssemblyType)')
  - [GetResourceContent(resourceName)](#M-Messaging-Resolvers-EmbeddedResourceResolver-GetResourceContent-System-String- 'Messaging.Resolvers.EmbeddedResourceResolver.GetResourceContent(System.String)')
- [Extensions](#T-Messaging-Extensions 'Messaging.Extensions')
  - [GetStream(content)](#M-Messaging-Extensions-GetStream-System-String- 'Messaging.Extensions.GetStream(System.String)')
  - [GetStreamFromAssembly(resourceName)](#M-Messaging-Extensions-GetStreamFromAssembly-System-String- 'Messaging.Extensions.GetStreamFromAssembly(System.String)')
  - [GetText(stream)](#M-Messaging-Extensions-GetText-System-IO-Stream- 'Messaging.Extensions.GetText(System.IO.Stream)')
  - [IsValidXml(xml)](#M-Messaging-Extensions-IsValidXml-System-String- 'Messaging.Extensions.IsValidXml(System.String)')
  - [MakeSureHasSchemaExtension(filename)](#M-Messaging-Extensions-MakeSureHasSchemaExtension-System-String- 'Messaging.Extensions.MakeSureHasSchemaExtension(System.String)')
- [IResourceResolver](#T-Messaging-Resolvers-IResourceResolver 'Messaging.Resolvers.IResourceResolver')
  - [GetResourceStream(resourceName)](#M-Messaging-Resolvers-IResourceResolver-GetResourceStream-System-String- 'Messaging.Resolvers.IResourceResolver.GetResourceStream(System.String)')
- [ResourceResolver](#T-Messaging-Resolvers-ResourceResolver 'Messaging.Resolvers.ResourceResolver')
  - [ResourceList](#P-Messaging-Resolvers-ResourceResolver-ResourceList 'Messaging.Resolvers.ResourceResolver.ResourceList')
  - [ResourceSourceName](#P-Messaging-Resolvers-ResourceResolver-ResourceSourceName 'Messaging.Resolvers.ResourceResolver.ResourceSourceName')
  - [FillMap()](#M-Messaging-Resolvers-ResourceResolver-FillMap 'Messaging.Resolvers.ResourceResolver.FillMap')
  - [GetEntity(absoluteUri,role,ofObjectToReturn)](#M-Messaging-Resolvers-ResourceResolver-GetEntity-System-Uri,System-String,System-Type- 'Messaging.Resolvers.ResourceResolver.GetEntity(System.Uri,System.String,System.Type)')
  - [GetResourceContent(resourceName)](#M-Messaging-Resolvers-ResourceResolver-GetResourceContent-System-String- 'Messaging.Resolvers.ResourceResolver.GetResourceContent(System.String)')
  - [GetResourceStream(resourceName)](#M-Messaging-Resolvers-ResourceResolver-GetResourceStream-System-String- 'Messaging.Resolvers.ResourceResolver.GetResourceStream(System.String)')
- [Resources](#T-Messaging-Core-Properties-Resources 'Messaging.Core.Properties.Resources')
  - [Culture](#P-Messaging-Core-Properties-Resources-Culture 'Messaging.Core.Properties.Resources.Culture')
  - [ResourceManager](#P-Messaging-Core-Properties-Resources-ResourceManager 'Messaging.Core.Properties.Resources.ResourceManager')
- [Result](#T-Messaging-Result 'Messaging.Result')
  - [#ctor(status,description,exception)](#M-Messaging-Result-#ctor-System-Boolean,System-String,System-Exception- 'Messaging.Result.#ctor(System.Boolean,System.String,System.Exception)')
  - [Description](#F-Messaging-Result-Description 'Messaging.Result.Description')
  - [ErrorException](#F-Messaging-Result-ErrorException 'Messaging.Result.ErrorException')
  - [Status](#F-Messaging-Result-Status 'Messaging.Result.Status')
  - [Error(error)](#M-Messaging-Result-Error-System-String- 'Messaging.Result.Error(System.String)')
  - [ErrorAndException(errorMessage,ex)](#M-Messaging-Result-ErrorAndException-System-String,System-Exception- 'Messaging.Result.ErrorAndException(System.String,System.Exception)')
  - [Exception(ex)](#M-Messaging-Result-Exception-System-Exception- 'Messaging.Result.Exception(System.Exception)')
  - [Success()](#M-Messaging-Result-Success 'Messaging.Result.Success')
- [SchemaValidator](#T-Messaging-Validators-SchemaValidator 'Messaging.Validators.SchemaValidator')
  - [#ctor(externalResolver)](#M-Messaging-Validators-SchemaValidator-#ctor-Messaging-Resolvers-ResourceResolver- 'Messaging.Validators.SchemaValidator.#ctor(Messaging.Resolvers.ResourceResolver)')
- [SchematronDocument](#T-Messaging-Validators-SchematronDocument 'Messaging.Validators.SchematronDocument')
  - [GenericCda](#F-Messaging-Validators-SchematronDocument-GenericCda 'Messaging.Validators.SchematronDocument.GenericCda')
  - [GenericCdaInteraction](#F-Messaging-Validators-SchematronDocument-GenericCdaInteraction 'Messaging.Validators.SchematronDocument.GenericCdaInteraction')
  - [PsisQuery](#F-Messaging-Validators-SchematronDocument-PsisQuery 'Messaging.Validators.SchematronDocument.PsisQuery')
  - [TemplatedCda](#F-Messaging-Validators-SchematronDocument-TemplatedCda 'Messaging.Validators.SchematronDocument.TemplatedCda')
- [SchematronValidator](#T-Messaging-Validators-SchematronValidator 'Messaging.Validators.SchematronValidator')
  - [#ctor(schematronContent,convertToIsoNamespace)](#M-Messaging-Validators-SchematronValidator-#ctor-System-String,System-Boolean- 'Messaging.Validators.SchematronValidator.#ctor(System.String,System.Boolean)')
  - [#ctor(schematronStream)](#M-Messaging-Validators-SchematronValidator-#ctor-System-IO-Stream- 'Messaging.Validators.SchematronValidator.#ctor(System.IO.Stream)')
  - [Create(schematronDocument)](#M-Messaging-Validators-SchematronValidator-Create-Messaging-Validators-SchematronDocument- 'Messaging.Validators.SchematronValidator.Create(Messaging.Validators.SchematronDocument)')
  - [Validate(inputXml)](#M-Messaging-Validators-SchematronValidator-Validate-System-String- 'Messaging.Validators.SchematronValidator.Validate(System.String)')
  - [Validate(inputStream)](#M-Messaging-Validators-SchematronValidator-Validate-System-IO-Stream- 'Messaging.Validators.SchematronValidator.Validate(System.IO.Stream)')
- [StylesheetDocument](#T-Messaging-Transformers-StylesheetDocument 'Messaging.Transformers.StylesheetDocument')
  - [CdaRenderer](#F-Messaging-Transformers-StylesheetDocument-CdaRenderer 'Messaging.Transformers.StylesheetDocument.CdaRenderer')
  - [CdaToTemplated](#F-Messaging-Transformers-StylesheetDocument-CdaToTemplated 'Messaging.Transformers.StylesheetDocument.CdaToTemplated')
  - [Nhs111PrimaryCdaRenderer](#F-Messaging-Transformers-StylesheetDocument-Nhs111PrimaryCdaRenderer 'Messaging.Transformers.StylesheetDocument.Nhs111PrimaryCdaRenderer')
  - [PostConversion](#F-Messaging-Transformers-StylesheetDocument-PostConversion 'Messaging.Transformers.StylesheetDocument.PostConversion')
  - [TemplatedToCda](#F-Messaging-Transformers-StylesheetDocument-TemplatedToCda 'Messaging.Transformers.StylesheetDocument.TemplatedToCda')
- [StylesheetTransformer](#T-Messaging-Transformers-StylesheetTransformer 'Messaging.Transformers.StylesheetTransformer')
  - [#ctor(resolver)](#M-Messaging-Transformers-StylesheetTransformer-#ctor-Messaging-Resolvers-ResourceResolver- 'Messaging.Transformers.StylesheetTransformer.#ctor(Messaging.Resolvers.ResourceResolver)')
  - [Transform(stylesheetDocument,inputXml)](#M-Messaging-Transformers-StylesheetTransformer-Transform-Messaging-Transformers-StylesheetDocument,System-String- 'Messaging.Transformers.StylesheetTransformer.Transform(Messaging.Transformers.StylesheetDocument,System.String)')
  - [Transform(stylesheetXml,inputXml)](#M-Messaging-Transformers-StylesheetTransformer-Transform-System-String,System-String- 'Messaging.Transformers.StylesheetTransformer.Transform(System.String,System.String)')
  - [TransformStream(stylesheetStream,inputXmlStream)](#M-Messaging-Transformers-StylesheetTransformer-TransformStream-System-IO-Stream,System-IO-Stream- 'Messaging.Transformers.StylesheetTransformer.TransformStream(System.IO.Stream,System.IO.Stream)')

<a name='T-Messaging-Resolvers-AssemblyType'></a>
## AssemblyType `type`

##### Namespace

Messaging.Resolvers

##### Summary

Enumeration of Assembly type

<a name='F-Messaging-Resolvers-AssemblyType-Caller'></a>
### Caller `constants`

##### Summary

Assembly that making the call, eg. for unit tests project

<a name='F-Messaging-Resolvers-AssemblyType-EntryHost'></a>
### EntryHost `constants`

##### Summary

Assembly that host the application e.g web project, desktop app, etc

<a name='F-Messaging-Resolvers-AssemblyType-Library'></a>
### Library `constants`

##### Summary

Library assembly, equivalent to Mim.Core assembly

<a name='T-Messaging-Validators-CdaValidator'></a>
## CdaValidator `type`

##### Namespace

Messaging.Validators

##### Summary

CdaValidator is used to validate against CDA generic format messages
It contains a series of validation and transformation:
- Schema validation against CDA generic message
- Schematron validation against CDA generic message
- Transformation to templated CDA message
- Schema validation against templated CDA message
- Schematron validation against templated CDA message

<a name='M-Messaging-Validators-CdaValidator-#ctor-Messaging-Resolvers-ResourceResolver-'></a>
### #ctor(externalResolver) `constructor`

##### Summary

[CdaValidator](#T-Messaging-Validators-CdaValidator 'Messaging.Validators.CdaValidator') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalResolver | [Messaging.Resolvers.ResourceResolver](#T-Messaging-Resolvers-ResourceResolver 'Messaging.Resolvers.ResourceResolver') | Resource resolver particularly for schema |

<a name='M-Messaging-Validators-CdaValidator-Create-System-Reflection-Assembly-'></a>
### Create(externalAssembly) `method`

##### Summary

Create is a [CdaValidator](#T-Messaging-Validators-CdaValidator 'Messaging.Validators.CdaValidator') static constructor

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalAssembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') | Assembly containing the schema as embedded resources |

<a name='M-Messaging-Validators-CdaValidator-Create-System-String-'></a>
### Create(folder) `method`

##### Summary

Create is a [CdaValidator](#T-Messaging-Validators-CdaValidator 'Messaging.Validators.CdaValidator') static constructor

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | folder containing the schema |

<a name='M-Messaging-Validators-CdaValidator-Validate-System-String,System-String,System-String-'></a>
### Validate(inputXml,templateSchemaName,genericCdaSchemaName) `method`

##### Summary

Validate the generic CDA message

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputXml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | generic CDA message in XML |
| templateSchemaName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | optional template schema name, if not present it will use whatever template schema name present in the input XML |
| genericCdaSchemaName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | optional CDA schema name, if not present if twill use whatever CDA schem name present in the input XML |

<a name='T-Messaging-Resolvers-DirectoryResourceResolver'></a>
## DirectoryResourceResolver `type`

##### Namespace

Messaging.Resolvers

##### Summary

DirectoryResourceResolver is resource resolver which use a directory in the disk as a source

<a name='M-Messaging-Resolvers-DirectoryResourceResolver-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

[DirectoryResourceResolver](#T-Messaging-Resolvers-DirectoryResourceResolver 'Messaging.Resolvers.DirectoryResourceResolver') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | directory on disk/volume to be used as source |

<a name='P-Messaging-Resolvers-DirectoryResourceResolver-ResourceList'></a>
### ResourceList `property`

##### Summary

List of resources in that directory, including all subdirectories's files

<a name='P-Messaging-Resolvers-DirectoryResourceResolver-ResourceSourceName'></a>
### ResourceSourceName `property`

##### Summary

Resource Source name

<a name='M-Messaging-Resolvers-DirectoryResourceResolver-GetResourceContent-System-String-'></a>
### GetResourceContent(resourceName) `method`

##### Summary

Get resource content based on the resource name

##### Returns

Return a stream for the resource

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource name |

<a name='T-Messaging-Resolvers-EmbeddedResourceResolver'></a>
## EmbeddedResourceResolver `type`

##### Namespace

Messaging.Resolvers

##### Summary

This class resolves resource by matching filename and extension of the embedded resources in an assembly

<a name='M-Messaging-Resolvers-EmbeddedResourceResolver-#ctor-System-Reflection-Assembly-'></a>
### #ctor(resourceAssembly) `constructor`

##### Summary

[EmbeddedResourceResolver](#T-Messaging-Resolvers-EmbeddedResourceResolver 'Messaging.Resolvers.EmbeddedResourceResolver') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceAssembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') | Resource assembly |

<a name='P-Messaging-Resolvers-EmbeddedResourceResolver-ResourceList'></a>
### ResourceList `property`

##### Summary

List of embedded resources in the assembly

<a name='P-Messaging-Resolvers-EmbeddedResourceResolver-ResourceSourceName'></a>
### ResourceSourceName `property`

##### Summary

Resource source name

<a name='M-Messaging-Resolvers-EmbeddedResourceResolver-Create-Messaging-Resolvers-AssemblyType-'></a>
### Create(assemblyType) `method`

##### Summary

[EmbeddedResourceResolver](#T-Messaging-Resolvers-EmbeddedResourceResolver 'Messaging.Resolvers.EmbeddedResourceResolver') static constructor

##### Returns

Return [EmbeddedResourceResolver](#T-Messaging-Resolvers-EmbeddedResourceResolver 'Messaging.Resolvers.EmbeddedResourceResolver')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblyType | [Messaging.Resolvers.AssemblyType](#T-Messaging-Resolvers-AssemblyType 'Messaging.Resolvers.AssemblyType') | Assembly containing the embedded resources |

<a name='M-Messaging-Resolvers-EmbeddedResourceResolver-GetResourceContent-System-String-'></a>
### GetResourceContent(resourceName) `method`

##### Summary

Get resource content stream based on the resource name

##### Returns

Return a stream of the resource

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resourc name |

<a name='T-Messaging-Extensions'></a>
## Extensions `type`

##### Namespace

Messaging

##### Summary

Extension methods to support usage of validator and transformer

<a name='M-Messaging-Extensions-GetStream-System-String-'></a>
### GetStream(content) `method`

##### Summary

Used to convert from string to stream representation

##### Returns

Return the equivalent stream

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | input in text representation |

<a name='M-Messaging-Extensions-GetStreamFromAssembly-System-String-'></a>
### GetStreamFromAssembly(resourceName) `method`

##### Summary

Get stream from embedded resource in the current code assembly

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Messaging-Extensions-GetText-System-IO-Stream-'></a>
### GetText(stream) `method`

##### Summary

Used to convert a stream to text representation

##### Returns

Return the equivalent text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Stream input |

<a name='M-Messaging-Extensions-IsValidXml-System-String-'></a>
### IsValidXml(xml) `method`

##### Summary

Check if xml is a valid XML content

##### Returns

Return true or false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | input XML |

<a name='M-Messaging-Extensions-MakeSureHasSchemaExtension-System-String-'></a>
### MakeSureHasSchemaExtension(filename) `method`

##### Summary

Check filename, if it does not have extension append with xsd extension

##### Returns

Return filename with xsd extension

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Filename |

<a name='T-Messaging-Resolvers-IResourceResolver'></a>
## IResourceResolver `type`

##### Namespace

Messaging.Resolvers

##### Summary

Interface for resource resolver

<a name='M-Messaging-Resolvers-IResourceResolver-GetResourceStream-System-String-'></a>
### GetResourceStream(resourceName) `method`

##### Summary

Signature to retrieve a stream from a resource name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Messaging-Resolvers-ResourceResolver'></a>
## ResourceResolver `type`

##### Namespace

Messaging.Resolvers

##### Summary

Resource resolver is abstract class contain both XMLUrlResolver and IResourceResolver implementation

<a name='P-Messaging-Resolvers-ResourceResolver-ResourceList'></a>
### ResourceList `property`

##### Summary

Get the resource list from this source

<a name='P-Messaging-Resolvers-ResourceResolver-ResourceSourceName'></a>
### ResourceSourceName `property`

##### Summary

Resource Source name

<a name='M-Messaging-Resolvers-ResourceResolver-FillMap'></a>
### FillMap() `method`

##### Summary

Create a map with key resourceName, and the actual resource path in the source

##### Parameters

This method has no parameters.

<a name='M-Messaging-Resolvers-ResourceResolver-GetEntity-System-Uri,System-String,System-Type-'></a>
### GetEntity(absoluteUri,role,ofObjectToReturn) `method`

##### Summary

Method from XMLUrlResolver to resolve an entity

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| absoluteUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Absolute Uri for the resource |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Role |
| ofObjectToReturn | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Object to return, by default this should be a stream |

<a name='M-Messaging-Resolvers-ResourceResolver-GetResourceContent-System-String-'></a>
### GetResourceContent(resourceName) `method`

##### Summary

Get resource stream based on the resource name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Messaging-Resolvers-ResourceResolver-GetResourceStream-System-String-'></a>
### GetResourceStream(resourceName) `method`

##### Summary

This is method for IResourceResolver which resolve a resourceName to a stream

##### Returns

Return a stream of the resource

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource name |

<a name='T-Messaging-Core-Properties-Resources'></a>
## Resources `type`

##### Namespace

Messaging.Core.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Messaging-Core-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Messaging-Core-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-Messaging-Result'></a>
## Result `type`

##### Namespace

Messaging

##### Summary

Result is return type for validator and stylesheet transformer in this assembly

<a name='M-Messaging-Result-#ctor-System-Boolean,System-String,System-Exception-'></a>
### #ctor(status,description,exception) `constructor`

##### Summary

[Result](#T-Messaging-Result 'Messaging.Result') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| status | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Status of the result: true or false |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description of the result |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Exception, by default the value is null |

<a name='F-Messaging-Result-Description'></a>
### Description `constants`

##### Summary

Description text

<a name='F-Messaging-Result-ErrorException'></a>
### ErrorException `constants`

##### Summary

Exception

<a name='F-Messaging-Result-Status'></a>
### Status `constants`

##### Summary

Status, can be true of false

<a name='M-Messaging-Result-Error-System-String-'></a>
### Error(error) `method`

##### Summary

Error result

##### Returns

Return an error result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| error | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error description |

<a name='M-Messaging-Result-ErrorAndException-System-String,System-Exception-'></a>
### ErrorAndException(errorMessage,ex) `method`

##### Summary

Error result with exception and error description

##### Returns

Return an error with exception and error description

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error description |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Exception |

<a name='M-Messaging-Result-Exception-System-Exception-'></a>
### Exception(ex) `method`

##### Summary

Error result with an exception

##### Returns

Return an error result with an exception

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Exception |

<a name='M-Messaging-Result-Success'></a>
### Success() `method`

##### Summary

Success result

##### Returns

Return a success result

##### Parameters

This method has no parameters.

<a name='T-Messaging-Validators-SchemaValidator'></a>
## SchemaValidator `type`

##### Namespace

Messaging.Validators

##### Summary

SchemaValidator is a schema validator

<a name='M-Messaging-Validators-SchemaValidator-#ctor-Messaging-Resolvers-ResourceResolver-'></a>
### #ctor(externalResolver) `constructor`

##### Summary

[SchemaValidator](#T-Messaging-Validators-SchemaValidator 'Messaging.Validators.SchemaValidator') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| externalResolver | [Messaging.Resolvers.ResourceResolver](#T-Messaging-Resolvers-ResourceResolver 'Messaging.Resolvers.ResourceResolver') | Resource resolver for the |

<a name='T-Messaging-Validators-SchematronDocument'></a>
## SchematronDocument `type`

##### Namespace

Messaging.Validators

##### Summary

Schematron content enumeration for NHS messages

<a name='F-Messaging-Validators-SchematronDocument-GenericCda'></a>
### GenericCda `constants`

##### Summary

Schematron content for generic CDA message

<a name='F-Messaging-Validators-SchematronDocument-GenericCdaInteraction'></a>
### GenericCdaInteraction `constants`

##### Summary

Schematron content for HL7 V3 interaction

<a name='F-Messaging-Validators-SchematronDocument-PsisQuery'></a>
### PsisQuery `constants`

##### Summary

Schematron content for PSIS Query message

<a name='F-Messaging-Validators-SchematronDocument-TemplatedCda'></a>
### TemplatedCda `constants`

##### Summary

Schematron content for templated CDA message

<a name='T-Messaging-Validators-SchematronValidator'></a>
## SchematronValidator `type`

##### Namespace

Messaging.Validators

##### Summary

SchematronValidator is an ISO compliant schematron validator

<a name='M-Messaging-Validators-SchematronValidator-#ctor-System-String,System-Boolean-'></a>
### #ctor(schematronContent,convertToIsoNamespace) `constructor`

##### Summary

[SchematronValidator](#T-Messaging-Validators-SchematronValidator 'Messaging.Validators.SchematronValidator') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schematronContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Schematron content message in XML format |
| convertToIsoNamespace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Flag to indicate whether or not to conver the old XML namespace to new ISO namespace
The old namespace: http://www.ascc.net/xml/schematron
The Iso namespace: http://purl.oclc.org/dsdl/schematron
The validation will fail on old namespace |

<a name='M-Messaging-Validators-SchematronValidator-#ctor-System-IO-Stream-'></a>
### #ctor(schematronStream) `constructor`

##### Summary

[SchematronValidator](#T-Messaging-Validators-SchematronValidator 'Messaging.Validators.SchematronValidator') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schematronStream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Schematron content stream |

<a name='M-Messaging-Validators-SchematronValidator-Create-Messaging-Validators-SchematronDocument-'></a>
### Create(schematronDocument) `method`

##### Summary

[SchemaValidator](#T-Messaging-Validators-SchemaValidator 'Messaging.Validators.SchemaValidator') static constructor with an enumerated schematron content for NHS messages)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schematronDocument | [Messaging.Validators.SchematronDocument](#T-Messaging-Validators-SchematronDocument 'Messaging.Validators.SchematronDocument') | Enumerated schematron content, the resources is contained wihtin Messaging.Core assembly |

<a name='M-Messaging-Validators-SchematronValidator-Validate-System-String-'></a>
### Validate(inputXml) `method`

##### Summary

Used to validate a message against the schematron content specified in the constructor

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputXml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | input message XML |

<a name='M-Messaging-Validators-SchematronValidator-Validate-System-IO-Stream-'></a>
### Validate(inputStream) `method`

##### Summary

Used to validate a message against the schematron content specified in the constructor

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputStream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | input message stream |

<a name='T-Messaging-Transformers-StylesheetDocument'></a>
## StylesheetDocument `type`

##### Namespace

Messaging.Transformers

##### Summary

Enumerated stylesheet content

<a name='F-Messaging-Transformers-StylesheetDocument-CdaRenderer'></a>
### CdaRenderer `constants`

##### Summary

Transform a generic CDA to viewable HTML

<a name='F-Messaging-Transformers-StylesheetDocument-CdaToTemplated'></a>
### CdaToTemplated `constants`

##### Summary

Transform a generic CDA to templated CDA message

<a name='F-Messaging-Transformers-StylesheetDocument-Nhs111PrimaryCdaRenderer'></a>
### Nhs111PrimaryCdaRenderer `constants`

##### Summary

Transform a generic CDA to viewable HTML for NHS 111 primary recipient

<a name='F-Messaging-Transformers-StylesheetDocument-PostConversion'></a>
### PostConversion `constants`

##### Summary

Transform a generic CDA or templated CDA after the conversion

<a name='F-Messaging-Transformers-StylesheetDocument-TemplatedToCda'></a>
### TemplatedToCda `constants`

##### Summary

Transform a templated CDA to a generic CDA message

<a name='T-Messaging-Transformers-StylesheetTransformer'></a>
## StylesheetTransformer `type`

##### Namespace

Messaging.Transformers

##### Summary

StylesheetTransformer is the stylesheet transformer

<a name='M-Messaging-Transformers-StylesheetTransformer-#ctor-Messaging-Resolvers-ResourceResolver-'></a>
### #ctor(resolver) `constructor`

##### Summary

[StylesheetTransformer](#T-Messaging-Transformers-StylesheetTransformer 'Messaging.Transformers.StylesheetTransformer') instance constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resolver | [Messaging.Resolvers.ResourceResolver](#T-Messaging-Resolvers-ResourceResolver 'Messaging.Resolvers.ResourceResolver') | Resource resolver, used to resolve any reference in the stylesheet content |

<a name='M-Messaging-Transformers-StylesheetTransformer-Transform-Messaging-Transformers-StylesheetDocument,System-String-'></a>
### Transform(stylesheetDocument,inputXml) `method`

##### Summary

Transform input XML using an enumerated stylessheet document contained in the Messaging.Core

##### Returns

Return a transformed XML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stylesheetDocument | [Messaging.Transformers.StylesheetDocument](#T-Messaging-Transformers-StylesheetDocument 'Messaging.Transformers.StylesheetDocument') | Enumerated stylesheet content |
| inputXml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | input XML |

<a name='M-Messaging-Transformers-StylesheetTransformer-Transform-System-String,System-String-'></a>
### Transform(stylesheetXml,inputXml) `method`

##### Summary

Transform inputXML based on an stylesheet XML

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stylesheetXml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Stylesheet XML |
| inputXml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | input XML |

<a name='M-Messaging-Transformers-StylesheetTransformer-TransformStream-System-IO-Stream,System-IO-Stream-'></a>
### TransformStream(stylesheetStream,inputXmlStream) `method`

##### Summary

Transform input stream using a stylesheet stream

##### Returns

Return a transformed stream

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stylesheetStream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | stylesheet stream |
| inputXmlStream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | input XML stream |
