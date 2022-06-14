Public Class Autenticação

    Public Shared Usuário As String
    Public Shared Senha As String
    Public Shared Nível As String

    Public Shared Sub Login(ByVal _Usuário As String, ByVal _Senha As String, ByVal _Nível As String)
        Usuário = _Usuário
        Senha = _Senha
        Nível = _Nível
    End Sub

    Public Shared Sub Recuperação(ByVal _Usuário As String, ByVal _Senha As String)
        Usuário = _Usuário
        Senha = _Senha
    End Sub

    Public Shared Function Exibir_Usuário() As String
        Return Usuário
    End Function

    Public Shared Function Exibir_Nível() As String
        Return Nível
    End Function

    Public Shared Function Exibir_Dados() As String
        Return "Usuário: " & Usuário & Environment.NewLine & "Senha: " & Senha
    End Function













End Class
