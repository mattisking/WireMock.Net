using System.Collections.Generic;

namespace WireMock.Admin.Mappings;

/// <summary>
/// RequestModel
/// </summary>
[FluentBuilder.AutoGenerateBuilder]
public class WebhookRequestModel
{
    /// <summary>
    /// Gets or sets the Url.
    /// </summary>
    public string Url { get; set; } = null!;

    /// <summary>
    /// The method
    /// </summary>
    public string Method { get; set; } = null!;

    /// <summary>
    /// Gets or sets the headers.
    /// </summary>
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>
    /// Gets or sets the body.
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Gets or sets the body (as JSON object).
    /// </summary>
    public object? BodyAsJson { get; set; }

    /// <summary>
    /// Use ResponseMessage Transformer.
    /// </summary>
    public bool? UseTransformer { get; set; }

    /// <summary>
    /// Gets the type of the transformer.
    /// </summary>
    public string? TransformerType { get; set; }

    /// <summary>
    /// The ReplaceNodeOptions to use when transforming a JSON node.
    /// </summary>
    public string? TransformerReplaceNodeOptions { get; set; }

    /// <summary>
    /// Use Fire and Forget (do not wait on result). Default value is false.
    /// </summary>
    public bool? UseFireAndForget { get; set; }
}