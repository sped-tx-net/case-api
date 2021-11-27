using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace System.Text.CodeGeneration
{
    public class CodeGenerationOptions
    {
        public OpenApiDocument Document { get; set; }
        public string ControllerNamespace { get; set; }
    }

    public class ControllerGenerator
    {
        private readonly IUsingDirectivesGenerator _usings;
        private readonly AttributeGenerator _attributes;

        public CompilationUnitSyntax GenerateController(CodeGenerationOptions options, List<TaggedOpenApiOperations> operations)
        {
            var tag = operations[0].Tag;

            var unit = SyntaxFactory.CompilationUnit();
            unit = unit.WithUsings(_usings.GenerateControllerUsings());

            var ns = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(options.ControllerNamespace));

            var manager = SyntaxFactory.ClassDeclaration(tag.Name);
            manager = manager.WithAttributeLists(_attributes.GenerateControllerClassAttributeLists());
            manager = manager.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));

            foreach (var operation in operations)
            {
            }

            return unit;
        }
    }


    public class MethodGenerator
    {
        public MethodDeclarationSyntax GenerateControllerMethod(OpenApiOperation operation)
        {
            return SyntaxFactory.MethodDeclaration(SyntaxFactory.GenericName(
        SyntaxFactory.Identifier("Task"))
    .WithTypeArgumentList(
        SyntaxFactory.TypeArgumentList(
            SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                SyntaxFactory.IdentifierName("IActionResult")))), operation.OperationId);
        }
    }
}



