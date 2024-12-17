global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using ExportBalance.Models;
global using ExportBalance.Presentation;
global using ExportBalance.DataContracts;
global using ExportBalance.DataContracts.Serialization;
global using ExportBalance.Services.Caching;
global using ExportBalance.Services.Endpoints;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]
