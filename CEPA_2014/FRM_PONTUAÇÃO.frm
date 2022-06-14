VERSION 5.00
Begin VB.Form FRM_PONTUAÇÃO 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Placar"
   ClientHeight    =   5955
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   8430
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5955
   ScaleWidth      =   8430
   StartUpPosition =   2  'CenterScreen
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
      Left            =   240
      TabIndex        =   9
      Top             =   240
      Width           =   4575
      Begin VB.PictureBox PIC_VER 
         AutoSize        =   -1  'True
         BorderStyle     =   0  'None
         Height          =   1500
         Left            =   120
         Picture         =   "FRM_PONTUAÇÃO.frx":0000
         ScaleHeight     =   1500
         ScaleWidth      =   1950
         TabIndex        =   11
         Top             =   600
         Width           =   1950
      End
      Begin VB.PictureBox PIC_AZU 
         AutoSize        =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   1500
         Left            =   2520
         Picture         =   "FRM_PONTUAÇÃO.frx":3DA2
         ScaleHeight     =   1500
         ScaleWidth      =   1950
         TabIndex        =   10
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
      Left            =   240
      TabIndex        =   6
      Top             =   3000
      Width           =   4575
      Begin VB.PictureBox PLACAR_AZU 
         AutoSize        =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   1350
         Left            =   2640
         Picture         =   "FRM_PONTUAÇÃO.frx":7BEC
         ScaleHeight     =   1350
         ScaleWidth      =   1650
         TabIndex        =   8
         Top             =   720
         Width           =   1650
      End
      Begin VB.PictureBox PLACAR_VER 
         AutoSize        =   -1  'True
         BorderStyle     =   0  'None
         Height          =   1350
         Left            =   360
         Picture         =   "FRM_PONTUAÇÃO.frx":B2D4
         ScaleHeight     =   1350
         ScaleWidth      =   1650
         TabIndex        =   7
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
   Begin VB.CommandButton CMDPREMIO 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Sortear Premio"
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
      Left            =   5520
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   3240
      Width           =   2295
   End
   Begin VB.CommandButton CMDSAIR 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Minimizar Placar"
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
      Left            =   5520
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   4560
      Width           =   2295
   End
   Begin VB.Frame FRM_PREMIO 
      BackColor       =   &H00FFFFFF&
      Caption         =   " Premiação "
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
      Left            =   5280
      TabIndex        =   0
      Top             =   240
      Width           =   2895
      Begin VB.Label PREMIO_AVISO 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Abra o armario numero:"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   9.75
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   720
         Width           =   2655
      End
      Begin VB.Label PREMIO_NUM 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFFFF&
         Caption         =   "???"
         BeginProperty Font 
            Name            =   "Nothing You Could Say"
            Size            =   39.75
            Charset         =   186
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Left            =   360
         TabIndex        =   2
         Top             =   1080
         Width           =   2295
      End
   End
   Begin VB.Label Label1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Desenvolvido por: Dumas Morais de Carvalho e Débora Nunes - Alunos do 2ºX"
      BeginProperty Font 
         Name            =   "Segoe Print"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   5640
      Width           =   7815
   End
End
Attribute VB_Name = "FRM_PONTUAÇÃO"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CMDPREMIO_Click()

PREMIO = CInt(Int((8 * Rnd()) + 1))
FRM_PREMIO.Visible = True
PREMIO_NUM.Caption = PREMIO

End Sub

Private Sub CMDSAIR_Click()

FRM_PONTUAÇÃO.Hide
FRM_CEPA.PIC_VER.Picture = LoadPicture(App.Path & "\IMG\Vermelho.jpg")
FRM_CEPA.PIC_AZU.Picture = LoadPicture(App.Path & "\IMG\Azul.jpg")

End Sub

