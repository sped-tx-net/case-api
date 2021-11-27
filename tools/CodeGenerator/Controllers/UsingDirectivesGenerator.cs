using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace System.Text.CodeGeneration
{
    public interface IUsingDirectivesGenerator
    {
        SyntaxList<UsingDirectiveSyntax> GenerateControllerUsings();
    }

    [Export(typeof(IUsingDirectivesGenerator))]
    public class UsingDirectivesGenerator : IUsingDirectivesGenerator
    {
        public SyntaxList<UsingDirectiveSyntax> GenerateControllerUsings()
        {
            return SyntaxFactory.List(new UsingDirectiveSyntax[]
            {
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Linq")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Collections.Generic")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Threading")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Threading.Tasks")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Microsoft.AspNetCore.Http")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Microsoft.AspNetCore.Mvc")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Swashbuckle.AspNetCore.Annotations")),
                SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.ComponentModel.DataAnnotations"))
            });
        }
    }
}
