using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerTest.App_Start
{
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}