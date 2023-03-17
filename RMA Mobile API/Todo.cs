
using System.ComponentModel;
using Swashbuckle.AspNetCore.Annotations;

[SwaggerSchema(Required = new[] { "Response trả về" })]

public class Todo
{
    [SwaggerSchema("The identifier", ReadOnly = true)]
    public int Id { get; set; }

    [SwaggerSchema("Tên công việc muốn làm")]
    public string? Name { get; set; }

    [DefaultValue(false), SwaggerSchema("Trạng thái công việc  đã hoàn thành")]
    public bool IsComplete { get; set; }
}