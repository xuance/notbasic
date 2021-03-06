﻿
Public Class FloatLiteralExpression
    Inherits Expression

    Public Property Value As Compilers.Scanners.Lexeme

    Sub New(literal As Compilers.Scanners.Lexeme)
        Me.Value = literal
    End Sub

    Public Overrides Function Accept(Of T)(visitor As ISyntaxTreeVisitor(Of T)) As T
        Return visitor.Visit(Me)
    End Function
End Class
