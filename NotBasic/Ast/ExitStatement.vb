﻿Public Class ExitStatement
    Inherits Statement

    Private _sourceSpan As Compilers.SourceSpan
    Private _lexemeValue As Compilers.Scanners.LexemeValue

    Sub New(sourceSpan As Compilers.SourceSpan, lexemeValue As Compilers.Scanners.LexemeValue)
        ' TODO: Complete member initialization 
        _sourceSpan = sourceSpan
        _lexemeValue = lexemeValue
    End Sub

End Class
