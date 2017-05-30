﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Test.Lightup
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using StyleCop.Analyzers.Lightup;
    using Xunit;

    public class ParenthesizedVariableDesignationSyntaxWrapperTests
    {
        [Fact]
        public void TestNull()
        {
            var syntaxNode = default(SyntaxNode);
            var parenthesizedVariableDesignationSyntax = (ParenthesizedVariableDesignationSyntaxWrapper)syntaxNode;
            Assert.Null(parenthesizedVariableDesignationSyntax.SyntaxNode);
            Assert.Throws<NullReferenceException>(() => parenthesizedVariableDesignationSyntax.OpenParenToken);
            Assert.Throws<NullReferenceException>(() => parenthesizedVariableDesignationSyntax.CloseParenToken);
        }

        [Fact]
        public void TestIsInstance()
        {
            Assert.False(ParenthesizedVariableDesignationSyntaxWrapper.IsInstance(null));
            Assert.False(ParenthesizedVariableDesignationSyntaxWrapper.IsInstance(SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression)));
        }

        [Fact]
        public void TestConversionsNull()
        {
            var syntaxNode = default(SyntaxNode);
            var parenthesizedVariableDesignationSyntax = (ParenthesizedVariableDesignationSyntaxWrapper)syntaxNode;

            VariableDesignationSyntaxWrapper variableDesignationSyntax = parenthesizedVariableDesignationSyntax;
            Assert.Null(variableDesignationSyntax.SyntaxNode);

            parenthesizedVariableDesignationSyntax = (ParenthesizedVariableDesignationSyntaxWrapper)variableDesignationSyntax;
            Assert.Null(parenthesizedVariableDesignationSyntax.SyntaxNode);

            SyntaxNode syntax = parenthesizedVariableDesignationSyntax;
            Assert.Null(syntax);
        }

        [Fact]
        public void TestInvalidConversion()
        {
            var syntaxNode = SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression);
            Assert.Throws<InvalidCastException>(() => (ParenthesizedVariableDesignationSyntaxWrapper)syntaxNode);
        }
    }
}
