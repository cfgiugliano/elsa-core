using System.Linq.Expressions;
using Elsa.Workflows.Management.Entities;

namespace Elsa.Workflows.Management.Models;

/// <summary>
/// Represents a summary view of a <see cref="WorkflowInstance"/>.
/// </summary>
public class WorkflowInstanceSummary
{
    /// <summary>
    /// Returns a summary view of the specified <see cref="WorkflowInstance"/>.
    /// </summary>
    public static WorkflowInstanceSummary FromInstance(WorkflowInstance workflowInstance)
    {
        return new()
        {
            Id = workflowInstance.Id,
            DefinitionId = workflowInstance.DefinitionId,
            DefinitionVersionId = workflowInstance.DefinitionVersionId,
            Version = workflowInstance.Version,
            Status = workflowInstance.Status,
            SubStatus = workflowInstance.SubStatus,
            CorrelationId = workflowInstance.CorrelationId,
            Name = workflowInstance.Name,
            IncidentCount = workflowInstance.IncidentCount,
            CreatedAt = workflowInstance.CreatedAt,
            UpdatedAt = workflowInstance.UpdatedAt,
            FinishedAt = workflowInstance.FinishedAt
        };
    }

    /// <summary>
    /// Returns a summary view of the specified <see cref="WorkflowInstance"/>.
    /// </summary>
    public static Expression<Func<WorkflowInstance, WorkflowInstanceSummary>> FromInstanceExpression() => workflowInstance => new()
    {
        Id = workflowInstance.Id,
        DefinitionId = workflowInstance.DefinitionId,
        DefinitionVersionId = workflowInstance.DefinitionVersionId,
        Version = workflowInstance.Version,
        Status = workflowInstance.Status,
        SubStatus = workflowInstance.SubStatus,
        CorrelationId = workflowInstance.CorrelationId,
        Name = workflowInstance.Name,
        IncidentCount = workflowInstance.IncidentCount,
        CreatedAt = workflowInstance.CreatedAt,
        UpdatedAt = workflowInstance.UpdatedAt,
        FinishedAt = workflowInstance.FinishedAt
    };


    /// <summary>The ID of the workflow instance.</summary>
    public string Id { get; set; } = null!;

    /// <summary>The ID of the workflow definition.</summary>
    public string DefinitionId { get; set; } = null!;

    /// <summary>The version ID of the workflow definition.</summary>
    public string DefinitionVersionId { get; set; } = null!;

    /// <summary>The version of the workflow definition.</summary>
    public int Version { get; set; }

    /// <summary>The status of the workflow instance.</summary>
    public WorkflowStatus Status { get; set; }

    /// <summary>The sub-status of the workflow instance.</summary>
    public WorkflowSubStatus SubStatus { get; set; }

    /// <summary>The ID of the workflow instance.</summary>
    public string? CorrelationId { get; set; }

    /// <summary>The name of the workflow instance.</summary>
    public string? Name { get; set; }

    /// <summary>The number of incidents associated with the workflow instance.</summary>
    public int IncidentCount { get; set; }

    /// <summary>The timestamp when the workflow instance was created.</summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>The timestamp when the workflow instance was last executed.</summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>The timestamp when the workflow instance was finished.</summary>
    public DateTimeOffset? FinishedAt { get; set; }
}