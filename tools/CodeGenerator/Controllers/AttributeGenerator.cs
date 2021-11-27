using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace System.Text.CodeGeneration
{
    public class AttributeGenerator
    {
        public SyntaxList<AttributeListSyntax> GenerateControllerClassAttributeLists()
        {
            return SyntaxFactory.List(nodes: new AttributeListSyntax[]
            {
                CreateSingletonAttribute("ApiController")
            });
        }

        private static TypeOfExpressionSyntax TypeOfList(string listType) => SyntaxFactory.TypeOfExpression(
            SyntaxFactory.GenericName(
                SyntaxFactory.Identifier("List"))
            .WithTypeArgumentList(
                SyntaxFactory.TypeArgumentList(
                    SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                        SyntaxFactory.IdentifierName(listType)))));

        public AttributeListSyntax GenerateSwaggerResponseAttribute(StatusCode statusCode, OpenApiResponse response)
        {
            var externalResouce = response.Content["application/json"].Schema.Reference.ExternalResource;
            var length = externalResouce.Length;

            string returnType = externalResouce.Split('/', StringSplitOptions.RemoveEmptyEntries)[length - 1];
            
            return SyntaxFactory.AttributeList(
            SyntaxFactory.SingletonSeparatedList<AttributeSyntax>(
                SyntaxFactory.Attribute(
                    SyntaxFactory.IdentifierName("SwaggerResponse"))
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList(
                        SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.IdentifierName("StatusCodes"),
                                        SyntaxFactory.IdentifierName(Enum.GetName(typeof(StatusCode), statusCode))))
                                .WithNameColon(
                                    SyntaxFactory.NameColon(
                                        SyntaxFactory.IdentifierName("statusCode"))),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        SyntaxFactory.Literal(response.Description)))
                                .WithNameColon(
                                    SyntaxFactory.NameColon(
                                        SyntaxFactory.IdentifierName("description"))),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.AttributeArgument(SyntaxFactory.TypeOfExpression(SyntaxFactory.IdentifierName(returnType)))
                                .WithNameColon(
                                    SyntaxFactory.NameColon(
                                        SyntaxFactory.IdentifierName("type")))})))));
        }

        private static AttributeListSyntax CreateSingletonAttribute(string identifierName)
        {
            return SyntaxFactory.AttributeList(
                SyntaxFactory.SingletonSeparatedList(
                    SyntaxFactory.Attribute(
                        SyntaxFactory.IdentifierName(identifierName),
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SeparatedList(
                                new AttributeArgumentSyntax[]
                                {

                                })))));
        }
    }
}



