﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompararElegir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvElegirGaraje = New System.Windows.Forms.DataGridView()
        CType(Me.dgvElegirGaraje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvElegirGaraje
        '
        Me.dgvElegirGaraje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElegirGaraje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElegirGaraje.Location = New System.Drawing.Point(0, 0)
        Me.dgvElegirGaraje.Name = "dgvElegirGaraje"
        Me.dgvElegirGaraje.Size = New System.Drawing.Size(800, 243)
        Me.dgvElegirGaraje.TabIndex = 1
        '
        'frmCompararElegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 243)
        Me.Controls.Add(Me.dgvElegirGaraje)
        Me.Name = "frmCompararElegir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir"
        CType(Me.dgvElegirGaraje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvElegirGaraje As DataGridView
End Class
