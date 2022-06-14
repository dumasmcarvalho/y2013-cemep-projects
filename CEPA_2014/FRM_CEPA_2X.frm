VERSION 5.00
Begin VB.Form FRM_CEPA 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cepa 2014 - 2ºX - Dinâmica de Perguntas"
   ClientHeight    =   9960
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   17250
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Segoe Print"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   9960
   ScaleWidth      =   17250
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame FRM_PLACAR 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Placar "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   2295
      Left            =   12240
      TabIndex        =   34
      Top             =   2880
      Width           =   4575
      Begin VB.PictureBox PLACAR_VER 
         AutoSize        =   -1  'True
         BorderStyle     =   0  'None
         Height          =   1350
         Left            =   360
         Picture         =   "FRM_CEPA_2X.frx":0000
         ScaleHeight     =   1350
         ScaleWidth      =   1650
         TabIndex        =   36
         Top             =   720
         Width           =   1650
      End
      Begin VB.PictureBox PLACAR_AZU 
         AutoSize        =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   1350
         Left            =   2640
         Picture         =   "FRM_CEPA_2X.frx":36E8
         ScaleHeight     =   1350
         ScaleWidth      =   1650
         TabIndex        =   35
         Top             =   720
         Width           =   1650
      End
      Begin VB.Line LIN 
         BorderColor     =   &H00808080&
         Index           =   0
         X1              =   2280
         X2              =   2280
         Y1              =   240
         Y2              =   2280
      End
   End
   Begin VB.Frame FRM_TIMES 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Times "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2415
      Left            =   12240
      TabIndex        =   31
      Top             =   120
      Width           =   4575
      Begin VB.PictureBox PIC_AZU 
         AutoSize        =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   1500
         Left            =   2520
         Picture         =   "FRM_CEPA_2X.frx":6DD0
         ScaleHeight     =   1500
         ScaleWidth      =   1950
         TabIndex        =   33
         Top             =   600
         Width           =   1950
      End
      Begin VB.PictureBox PIC_VER 
         AutoSize        =   -1  'True
         BorderStyle     =   0  'None
         Height          =   1500
         Left            =   120
         Picture         =   "FRM_CEPA_2X.frx":AC1A
         ScaleHeight     =   1500
         ScaleWidth      =   1950
         TabIndex        =   32
         Top             =   600
         Width           =   1950
      End
      Begin VB.Line LIN 
         BorderColor     =   &H00808080&
         Index           =   1
         X1              =   2280
         X2              =   2280
         Y1              =   240
         Y2              =   2400
      End
   End
   Begin VB.CommandButton CMDEXIBIR 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Exibir Placar"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   11.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   15360
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   6720
      Width           =   1575
   End
   Begin VB.CommandButton CMDCOM 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Comparar"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   11.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   15360
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   5640
      Width           =   1575
   End
   Begin VB.CommandButton CMDZERAR 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Zerar"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   11.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   15360
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   7800
      Width           =   1575
   End
   Begin VB.CommandButton CMDSAIR 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Sair"
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   11.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   15360
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   8880
      Width           =   1575
   End
   Begin VB.Frame FRM_ALT_B 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Alternativas (Time Azul) "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4215
      Left            =   9360
      TabIndex        =   16
      Top             =   5520
      Width           =   5655
      Begin VB.OptionButton ALT_B 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   1
         Left            =   600
         TabIndex        =   20
         Top             =   720
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_B 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   2
         Left            =   600
         TabIndex        =   19
         Top             =   1560
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_B 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   3
         Left            =   600
         TabIndex        =   18
         Top             =   2520
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_B 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   4
         Left            =   600
         TabIndex        =   17
         Top             =   3480
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.Image ANO 
         Height          =   1425
         Left            =   1080
         Picture         =   "FRM_CEPA_2X.frx":E9BC
         Top             =   1560
         Width           =   3570
      End
      Begin VB.Label A 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "A"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   24
         Top             =   720
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label B 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   23
         Top             =   1560
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label C 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "C"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   22
         Top             =   2520
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label D 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "D"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   21
         Top             =   3480
         Visible         =   0   'False
         Width           =   375
      End
   End
   Begin VB.Frame FRM_ALT_A 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Alternativas (Time Vermelho) "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4215
      Left            =   3480
      TabIndex        =   8
      Top             =   5520
      Width           =   5655
      Begin VB.OptionButton ALT_A 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   3
         Left            =   600
         TabIndex        =   10
         Top             =   2520
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_A 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   1
         Left            =   600
         TabIndex        =   12
         Top             =   720
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_A 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   2
         Left            =   600
         TabIndex        =   11
         Top             =   1560
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.OptionButton ALT_A 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Index           =   4
         Left            =   600
         TabIndex        =   9
         Top             =   3480
         Visible         =   0   'False
         Width           =   4815
      End
      Begin VB.Image CEPA 
         Height          =   1515
         Left            =   840
         Picture         =   "FRM_CEPA_2X.frx":13217
         Top             =   1560
         Width           =   3900
      End
      Begin VB.Label A 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "A"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   26
         Top             =   720
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label B 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   15
         Top             =   1560
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label C 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "C"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   14
         Top             =   2520
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label D 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "D"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   12
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   13
         Top             =   3480
         Visible         =   0   'False
         Width           =   375
      End
   End
   Begin VB.Frame FRM_TEM 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Temas "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   7095
      Left            =   240
      TabIndex        =   3
      Top             =   2640
      Width           =   2775
      Begin VB.OptionButton TEM 
         BackColor       =   &H00FFFFFF&
         Caption         =   "História do Computador"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   11.25
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Index           =   5
         Left            =   240
         Style           =   1  'Graphical
         TabIndex        =   29
         Top             =   6120
         Width           =   2220
      End
      Begin VB.OptionButton TEM 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Internet"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   11.25
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Index           =   1
         Left            =   240
         MaskColor       =   &H00FFFFFF&
         Style           =   1  'Graphical
         TabIndex        =   7
         Top             =   840
         Width           =   2220
      End
      Begin VB.OptionButton TEM 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Hardware"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   11.25
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Index           =   2
         Left            =   240
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   2160
         Width           =   2220
      End
      Begin VB.OptionButton TEM 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Software"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   11.25
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Index           =   3
         Left            =   240
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   3480
         Width           =   2220
      End
      Begin VB.OptionButton TEM 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Sistemas Operacionais"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   11.25
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Index           =   4
         Left            =   240
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   4800
         Width           =   2220
      End
   End
   Begin VB.Frame FRM_PER 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Perguntas "
      BeginProperty Font 
         Name            =   "Nothing You Could Say"
         Size            =   14.25
         Charset         =   186
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2535
      Left            =   3480
      TabIndex        =   0
      Top             =   2640
      Width           =   8295
      Begin VB.OptionButton PER 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   360
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   1560
         Visible         =   0   'False
         Width           =   7575
      End
      Begin VB.OptionButton PER 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   360
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   840
         Visible         =   0   'False
         Width           =   7575
      End
      Begin VB.Image SEJAM 
         Height          =   1320
         Left            =   360
         Picture         =   "FRM_CEPA_2X.frx":17D4D
         Top             =   720
         Width           =   7500
      End
   End
   Begin VB.Image LOGO 
      Height          =   1455
      Left            =   720
      Picture         =   "FRM_CEPA_2X.frx":1D59B
      Top             =   600
      Width           =   10200
   End
End
Attribute VB_Name = "FRM_CEPA"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CMDCOM_Click()

If TEM(1).Value = True Then
    If PER(1).Value = True And ALT_A(3).Value = True And ALT_B(3).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 2
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 2
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(1).Value = True And ALT_A(3).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 2
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(1).Value = True And ALT_B(3).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 2
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(1).Value = True And ALT_A(3).Value = False And ALT_B(3).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
    If PER(2).Value = True And ALT_A(4).Value = True And ALT_B(4).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 2
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 2
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(2).Value = True And ALT_A(4).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 2
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(2).Value = True And ALT_B(4).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 2
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(2).Value = True And ALT_A(4).Value = False And ALT_B(4).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
End If



If TEM(2).Value = True Then
    If PER(1).Value = True And ALT_A(2).Value = True And ALT_B(2).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 2
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 2
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(1).Value = True And ALT_A(2).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 2
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(1).Value = True And ALT_B(2).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 2
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(1).Value = True And ALT_A(2).Value = False And ALT_B(2).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
    If PER(2).Value = True And ALT_A(1).Value = True And ALT_B(1).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 3
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 3
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(2).Value = True And ALT_A(1).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 3
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(2).Value = True And ALT_B(1).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 3
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(2).Value = True And ALT_A(1).Value = False And ALT_B(1).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
End If



If TEM(3).Value = True Then
    If PER(1).Value = True And ALT_A(4).Value = True And ALT_B(4).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 3
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 3
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(1).Value = True And ALT_A(4).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 3
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(1).Value = True And ALT_B(4).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 3
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(1).Value = True And ALT_A(4).Value = False And ALT_B(4).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
    If PER(2).Value = True And ALT_A(3).Value = True And ALT_B(3).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 2
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 2
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(2).Value = True And ALT_A(3).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 2
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(2).Value = True And ALT_B(3).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 2
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(2).Value = True And ALT_A(3).Value = False And ALT_B(3).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
End If


If TEM(4).Value = True Then
    If PER(1).Value = True And ALT_A(1).Value = True And ALT_B(1).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 2
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 2
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(1).Value = True And ALT_A(1).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 2
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(1).Value = True And ALT_B(1).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 2
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(1).Value = True And ALT_A(1).Value = False And ALT_B(1).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
    If PER(2).Value = True And ALT_A(2).Value = True And ALT_B(2).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 3
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 3
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(2).Value = True And ALT_A(2).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 3
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(2).Value = True And ALT_B(2).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 3
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(2).Value = True And ALT_A(2).Value = False And ALT_B(2).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
End If



If TEM(5).Value = True Then
    If PER(1).Value = True And ALT_A(4).Value = True And ALT_B(4).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 3
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 3
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(1).Value = True And ALT_A(4).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 3
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(1).Value = True And ALT_B(4).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 3
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(1).Value = True And ALT_A(4).Value = False And ALT_B(4).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
    If PER(2).Value = True And ALT_A(1).Value = True And ALT_B(1).Value = True Then
            MsgBox "Os dois times acertaram!", vbInformation, "Aviso"
            VERMELHO = VERMELHO + 3
            If VERMELHO > 25 Then VERMELHO = 25
            PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
            AZUL = AZUL + 3
            If AZUL > 25 Then AZUL = 25
            PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
            ElseIf PER(2).Value = True And ALT_A(1).Value = True Then
            MsgBox "O time Vermelho acertou!", vbInformation, "Aviso"
                VERMELHO = VERMELHO + 3
                If VERMELHO > 25 Then VERMELHO = 25
                PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
                ElseIf PER(2).Value = True And ALT_B(1).Value = True Then
                MsgBox "O time Azul acertou!", vbInformation, "Aviso"
                    AZUL = AZUL + 3
                    If AZUL > 25 Then AZUL = 25
                    PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
                    ElseIf PER(2).Value = True And ALT_A(1).Value = False And ALT_B(1).Value = False Then
                    MsgBox "Nenhum time acertou!", vbCritical, "Aviso"
    End If
End If

ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

End Sub


Private Sub CMDEXIBIR_Click()

If VERMELHO Or AZUL >= 10 Then FRM_PONTUAÇÃO.CMDPREMIO.Enabled = True Else MsgBox "Nenhum time conseguiu alcançar a pontuação mínima! (10 Pontos)", vbCritical, "Aviso"
PIC_VER.Picture = LoadPicture(App.Path & "\IMG\Vermelho_Cinza.jpg")
PIC_AZU.Picture = LoadPicture(App.Path & "\IMG\Azul_Cinza.jpg")
FRM_PONTUAÇÃO.Show vbModal

End Sub

Private Sub CMDSAIR_Click()

End

End Sub

Private Sub CMDZERAR_Click()

TEM(1).Value = False
TEM(2).Value = False
TEM(3).Value = False
TEM(4).Value = False
TEM(5).Value = False

PER(1).Value = False
PER(2).Value = False
PER(1).Visible = False
PER(2).Visible = False
PER(1).Caption = Empty
PER(2).Caption = Empty

ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False
ALT_A(1).Visible = False
ALT_A(2).Visible = False
ALT_A(3).Visible = False
ALT_A(4).Visible = False
ALT_A(1).Caption = Empty
ALT_A(2).Caption = Empty
ALT_A(3).Caption = Empty
ALT_A(4).Caption = Empty


ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False
ALT_B(1).Visible = False
ALT_B(2).Visible = False
ALT_B(3).Visible = False
ALT_B(4).Visible = False
ALT_B(1).Caption = Empty
ALT_B(2).Caption = Empty
ALT_B(3).Caption = Empty
ALT_B(4).Caption = Empty

A(1).Visible = False
A(0).Visible = False
B(1).Visible = False
B(0).Visible = False
C(1).Visible = False
C(0).Visible = False
D(1).Visible = False
D(0).Visible = False

SEJAM.Visible = True
CEPA.Visible = True
ANO.Visible = True

PREMIO = 0
CMDCOM.Enabled = False
CMDZERAR.Enabled = False
CMDEXIBIR.Enabled = False
FRM_PONTUAÇÃO.PREMIO_NUM.Caption = "???"
FRM_PONTUAÇÃO.CMDPREMIO.Enabled = False

VERMELHO = 0
FRM_PONTUAÇÃO.PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")
PLACAR_VER.Picture = LoadPicture(App.Path & "\IMG\" & VERMELHO & ".jpg")

AZUL = 0
FRM_PONTUAÇÃO.PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")
PLACAR_AZU.Picture = LoadPicture(App.Path & "\IMG\" & AZUL & ".jpg")

End Sub

Private Sub Form_Load()

TEM(1).Value = False
TEM(2).Value = False
TEM(3).Value = False
TEM(4).Value = False
TEM(5).Value = False

PER(1).Value = False
PER(2).Value = False

ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

End Sub

Private Sub PER_Click(Index As Integer)

ALT_A(1).Visible = True
ALT_A(2).Visible = True
ALT_A(3).Visible = True
ALT_A(4).Visible = True

ALT_B(1).Visible = True
ALT_B(2).Visible = True
ALT_B(3).Visible = True
ALT_B(4).Visible = True

CMDZERAR.Enabled = True
CMDCOM.Enabled = True
CMDEXIBIR.Enabled = True
CEPA.Visible = False
ANO.Visible = False


A(1).Visible = True
A(0).Visible = True
B(1).Visible = True
B(0).Visible = True
C(1).Visible = True
C(0).Visible = True
D(1).Visible = True
D(0).Visible = True


If TEM(1).Value = True Then

ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

    Select Case Index
        Case 1
            ALT_A(1).Caption = "Bill Gates"
            ALT_A(2).Caption = "Larry Page"
            ALT_A(3).Caption = "Mark Zuckerberg"
            ALT_A(4).Caption = "Jack Dorsey"
            
            ALT_B(1).Caption = "Bill Gates"
            ALT_B(2).Caption = "Larry Page"
            ALT_B(3).Caption = "Mark Zuckerberg"
            ALT_B(4).Caption = "Jack Dorsey"
        Case 2
            ALT_A(1).Caption = "Yahoo"
            ALT_A(2).Caption = "Ask"
            ALT_A(3).Caption = "Bing"
            ALT_A(4).Caption = "Google"
            
            ALT_B(1).Caption = "Yahoo"
            ALT_B(2).Caption = "Ask"
            ALT_B(3).Caption = "Bing"
            ALT_B(4).Caption = "Google"
    End Select
ElseIf TEM(2).Value = True Then

ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

    Select Case Index
        Case 1
            ALT_A(1).Caption = "Visualizar videos do Youtube e os demais"
            ALT_A(2).Caption = "Gerar toda parte grafica do computador e aumentar seu desempenho"
            ALT_A(3).Caption = "Reproduzir o áudio do computador"
            ALT_A(4).Caption = "Aumentar a capacidade de armazenamento do computador"
            
            ALT_B(1).Caption = "Visualizar videos do Youtube e os demais"
            ALT_B(2).Caption = "Gerar toda parte grafica do computador e aumentar seu desempenho"
            ALT_B(3).Caption = "Reproduzir o áudio do computador"
            ALT_B(4).Caption = "Aumentar a capacidade de armazenamento do computador"
        Case 2
            ALT_A(1).Caption = "Armazenar dados do computador"
            ALT_A(2).Caption = "Aumentar o desempenho do computador"
            ALT_A(3).Caption = "Influênciar no desempenho de vídeos e jogos"
            ALT_A(4).Caption = "Controlar a entrada de discos"
            
            ALT_B(1).Caption = "Armazenar dados do computador"
            ALT_B(2).Caption = "Aumentar o desempenho do computador"
            ALT_B(3).Caption = "Influênciar no desempenho de vídeos e jogos"
            ALT_B(4).Caption = "Controlar a entrada de discos"
    End Select
ElseIf TEM(3).Value = True Then
    
ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

    Select Case Index
        Case 1
            ALT_A(1).Caption = "Google Chrome"
            ALT_A(2).Caption = "Avast"
            ALT_A(3).Caption = "Windows Media Player"
            ALT_A(4).Caption = "Prompt de Comando"
            
            ALT_B(1).Caption = "Google Chrome"
            ALT_B(2).Caption = "Avast"
            ALT_B(3).Caption = "Windows Media Player"
            ALT_B(4).Caption = "Prompt de Comando"
        Case 2
            ALT_A(1).Caption = "Word"
            ALT_A(2).Caption = "Access"
            ALT_A(3).Caption = "Power Point"
            ALT_A(4).Caption = "Excel"
            
            ALT_B(1).Caption = "Word"
            ALT_B(2).Caption = "Access"
            ALT_B(3).Caption = "Power Point"
            ALT_B(4).Caption = "Excel"
    End Select
ElseIf TEM(4).Value = True Then
    
ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

    Select Case Index
        Case 1
            ALT_A(1).Caption = "Windows"
            ALT_A(2).Caption = "Linux"
            ALT_A(3).Caption = "Mac"
            ALT_A(4).Caption = "Android"
            
            ALT_B(1).Caption = "Windows"
            ALT_B(2).Caption = "Linux"
            ALT_B(3).Caption = "Mac"
            ALT_B(4).Caption = "Android"
        Case 2
            ALT_A(1).Caption = "Solaris"
            ALT_A(2).Caption = "Linux"
            ALT_A(3).Caption = "Mac"
            ALT_A(4).Caption = "Windows"
            
            ALT_B(1).Caption = "Solaris"
            ALT_B(2).Caption = "Linux"
            ALT_B(3).Caption = "Mac"
            ALT_B(4).Caption = "Windows"
    End Select
ElseIf TEM(5).Value = True Then
    
ALT_A(1).Value = False
ALT_A(2).Value = False
ALT_A(3).Value = False
ALT_A(4).Value = False

ALT_B(1).Value = False
ALT_B(2).Value = False
ALT_B(3).Value = False
ALT_B(4).Value = False

    Select Case Index
        Case 1
            ALT_A(1).Caption = "Macintosh"
            ALT_A(2).Caption = "Unitron Mac 512"
            ALT_A(3).Caption = "TK 3000 //e"
            ALT_A(4).Caption = "Pascalina"
            
            ALT_B(1).Caption = "Macintosh"
            ALT_B(2).Caption = "Unitron Mac 512"
            ALT_B(3).Caption = "TK 3000 //e"
            ALT_B(4).Caption = "Pascalina"
        Case 2
            ALT_A(1).Caption = "ENIAC"
            ALT_A(2).Caption = "Macintosh Plus"
            ALT_A(3).Caption = "Agat"
            ALT_A(4).Caption = "BBC Micro"
            
            ALT_B(1).Caption = "ENIAC"
            ALT_B(2).Caption = "Macintosh Plus"
            ALT_B(3).Caption = "Agat"
            ALT_B(4).Caption = "BBC Micro"
    End Select
End If

End Sub

Private Sub TEM_Click(Index As Integer)

PER(1).Visible = True
PER(2).Visible = True

SEJAM.Visible = False

A(1).Visible = False
A(0).Visible = False
B(1).Visible = False
B(0).Visible = False
C(1).Visible = False
C(0).Visible = False
D(1).Visible = False
D(0).Visible = False

Select Case Index
    Case 1
        PER(1).Caption = "Quem é o fundador da rede social Facebook? - 2Pts"
        PER(2).Caption = "Qual é o provedor de pesquisas mais utilizado no mundo? - 2Pts"
        
        PER(1).Value = False
        PER(2).Value = False
        
        ALT_A(1).Visible = False
        ALT_A(2).Visible = False
        ALT_A(3).Visible = False
        ALT_A(4).Visible = False

        ALT_B(1).Visible = False
        ALT_B(2).Visible = False
        ALT_B(3).Visible = False
        ALT_B(4).Visible = False
        
    Case 2
        PER(1).Caption = "Qual é a função de uma placa de vídeo? - 2Pts"
        PER(2).Caption = "Qual é a função de um HD (Hard Disk/Disco Rígido)? - 3Pts"
        
        PER(1).Value = False
        PER(2).Value = False
        
        ALT_A(1).Visible = False
        ALT_A(2).Visible = False
        ALT_A(3).Visible = False
        ALT_A(4).Visible = False

        ALT_B(1).Visible = False
        ALT_B(2).Visible = False
        ALT_B(3).Visible = False
        ALT_B(4).Visible = False

    Case 3
        PER(1).Caption = "Qual das seguintes alternativas não é um programa? - 3Pts"
        PER(2).Caption = "Qual programa é utilizado para criação de slides? - 2Pts"
        
        PER(1).Value = False
        PER(2).Value = False
        
        ALT_A(1).Visible = False
        ALT_A(2).Visible = False
        ALT_A(3).Visible = False
        ALT_A(4).Visible = False

        ALT_B(1).Visible = False
        ALT_B(2).Visible = False
        ALT_B(3).Visible = False
        ALT_B(4).Visible = False
        
    Case 4
        PER(1).Caption = "Qual é a família de S.O mais utilizada no mundo? - 2Pts"
        PER(2).Caption = "Qual é S.O mais utilizado por empresas por ser mais seguro? - 3Pts"
        
        PER(1).Value = False
        PER(2).Value = False
        
        ALT_A(1).Visible = False
        ALT_A(2).Visible = False
        ALT_A(3).Visible = False
        ALT_A(4).Visible = False

        ALT_B(1).Visible = False
        ALT_B(2).Visible = False
        ALT_B(3).Visible = False
        ALT_B(4).Visible = False
        
    Case 5
        PER(1).Caption = "Qual das alternativas não é um computador? - 3Pts"
        PER(2).Caption = "Qual foi o primeiro computador digital criado? - 3Pts"
        
        PER(1).Value = False
        PER(2).Value = False
        
        ALT_A(1).Visible = False
        ALT_A(2).Visible = False
        ALT_A(3).Visible = False
        ALT_A(4).Visible = False

        ALT_B(1).Visible = False
        ALT_B(2).Visible = False
        ALT_B(3).Visible = False
        ALT_B(4).Visible = False
End Select

End Sub
