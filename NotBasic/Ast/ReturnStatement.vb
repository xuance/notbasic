﻿
Public Class ReturnStatement
    Inherits Statement

    Private _sourceSpan As Compilers.SourceSpan
    Private _returnValue As Expression

    Sub New(sourceSpan As Compilers.SourceSpan, returnValue As Expression)
        ' TODO: Complete member initialization 
        _sourceSpan = sourceSpan
        _returnValue = returnValue
    End Sub

End Class