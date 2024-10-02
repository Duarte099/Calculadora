<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.BotDividir = New System.Windows.Forms.Button()
        Me.Bot0 = New System.Windows.Forms.Button()
        Me.BotMultiplicar = New System.Windows.Forms.Button()
        Me.BotCalcular = New System.Windows.Forms.Button()
        Me.Bot1 = New System.Windows.Forms.Button()
        Me.Bot2 = New System.Windows.Forms.Button()
        Me.Bot3 = New System.Windows.Forms.Button()
        Me.BotSomar = New System.Windows.Forms.Button()
        Me.Bot4 = New System.Windows.Forms.Button()
        Me.Bot5 = New System.Windows.Forms.Button()
        Me.Bot6 = New System.Windows.Forms.Button()
        Me.BotSubtrair = New System.Windows.Forms.Button()
        Me.Bot7 = New System.Windows.Forms.Button()
        Me.Bot8 = New System.Windows.Forms.Button()
        Me.Bot9 = New System.Windows.Forms.Button()
        Me.BotBackspace = New System.Windows.Forms.Button()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtOp = New System.Windows.Forms.TextBox()
        Me.botPonto = New System.Windows.Forms.Button()
        Me.BotClean = New System.Windows.Forms.Button()
        Me.botInverter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BotDividir
        '
        Me.BotDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotDividir.Location = New System.Drawing.Point(180, 100)
        Me.BotDividir.Name = "BotDividir"
        Me.BotDividir.Size = New System.Drawing.Size(50, 50)
        Me.BotDividir.TabIndex = 1
        Me.BotDividir.Text = "÷"
        Me.BotDividir.UseVisualStyleBackColor = True
        '
        'Bot0
        '
        Me.Bot0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot0.Location = New System.Drawing.Point(68, 324)
        Me.Bot0.Name = "Bot0"
        Me.Bot0.Size = New System.Drawing.Size(50, 50)
        Me.Bot0.TabIndex = 2
        Me.Bot0.Text = "0"
        Me.Bot0.UseVisualStyleBackColor = True
        '
        'BotMultiplicar
        '
        Me.BotMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotMultiplicar.Location = New System.Drawing.Point(180, 156)
        Me.BotMultiplicar.Name = "BotMultiplicar"
        Me.BotMultiplicar.Size = New System.Drawing.Size(50, 50)
        Me.BotMultiplicar.TabIndex = 3
        Me.BotMultiplicar.Text = "x"
        Me.BotMultiplicar.UseVisualStyleBackColor = True
        '
        'BotCalcular
        '
        Me.BotCalcular.BackColor = System.Drawing.SystemColors.Highlight
        Me.BotCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotCalcular.Location = New System.Drawing.Point(180, 324)
        Me.BotCalcular.Name = "BotCalcular"
        Me.BotCalcular.Size = New System.Drawing.Size(50, 50)
        Me.BotCalcular.TabIndex = 4
        Me.BotCalcular.Text = "="
        Me.BotCalcular.UseVisualStyleBackColor = False
        '
        'Bot1
        '
        Me.Bot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot1.Location = New System.Drawing.Point(12, 268)
        Me.Bot1.Name = "Bot1"
        Me.Bot1.Size = New System.Drawing.Size(50, 50)
        Me.Bot1.TabIndex = 5
        Me.Bot1.Text = "1"
        Me.Bot1.UseVisualStyleBackColor = True
        '
        'Bot2
        '
        Me.Bot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot2.Location = New System.Drawing.Point(68, 268)
        Me.Bot2.Name = "Bot2"
        Me.Bot2.Size = New System.Drawing.Size(50, 50)
        Me.Bot2.TabIndex = 6
        Me.Bot2.Text = "2"
        Me.Bot2.UseVisualStyleBackColor = True
        '
        'Bot3
        '
        Me.Bot3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot3.Location = New System.Drawing.Point(124, 267)
        Me.Bot3.Name = "Bot3"
        Me.Bot3.Size = New System.Drawing.Size(50, 50)
        Me.Bot3.TabIndex = 7
        Me.Bot3.Text = "3"
        Me.Bot3.UseVisualStyleBackColor = True
        '
        'BotSomar
        '
        Me.BotSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotSomar.Location = New System.Drawing.Point(180, 268)
        Me.BotSomar.Name = "BotSomar"
        Me.BotSomar.Size = New System.Drawing.Size(50, 50)
        Me.BotSomar.TabIndex = 8
        Me.BotSomar.Text = "+"
        Me.BotSomar.UseVisualStyleBackColor = True
        '
        'Bot4
        '
        Me.Bot4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot4.Location = New System.Drawing.Point(12, 212)
        Me.Bot4.Name = "Bot4"
        Me.Bot4.Size = New System.Drawing.Size(50, 50)
        Me.Bot4.TabIndex = 9
        Me.Bot4.Text = "4"
        Me.Bot4.UseVisualStyleBackColor = True
        '
        'Bot5
        '
        Me.Bot5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot5.Location = New System.Drawing.Point(68, 212)
        Me.Bot5.Name = "Bot5"
        Me.Bot5.Size = New System.Drawing.Size(50, 50)
        Me.Bot5.TabIndex = 10
        Me.Bot5.Text = "5"
        Me.Bot5.UseVisualStyleBackColor = True
        '
        'Bot6
        '
        Me.Bot6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot6.Location = New System.Drawing.Point(124, 211)
        Me.Bot6.Name = "Bot6"
        Me.Bot6.Size = New System.Drawing.Size(50, 50)
        Me.Bot6.TabIndex = 11
        Me.Bot6.Text = "6"
        Me.Bot6.UseVisualStyleBackColor = True
        '
        'BotSubtrair
        '
        Me.BotSubtrair.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotSubtrair.Location = New System.Drawing.Point(180, 212)
        Me.BotSubtrair.Name = "BotSubtrair"
        Me.BotSubtrair.Size = New System.Drawing.Size(50, 50)
        Me.BotSubtrair.TabIndex = 12
        Me.BotSubtrair.Text = "-"
        Me.BotSubtrair.UseVisualStyleBackColor = True
        '
        'Bot7
        '
        Me.Bot7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot7.Location = New System.Drawing.Point(12, 156)
        Me.Bot7.Name = "Bot7"
        Me.Bot7.Size = New System.Drawing.Size(50, 50)
        Me.Bot7.TabIndex = 13
        Me.Bot7.Text = "7"
        Me.Bot7.UseVisualStyleBackColor = True
        '
        'Bot8
        '
        Me.Bot8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot8.Location = New System.Drawing.Point(68, 156)
        Me.Bot8.Name = "Bot8"
        Me.Bot8.Size = New System.Drawing.Size(50, 50)
        Me.Bot8.TabIndex = 14
        Me.Bot8.Text = "8"
        Me.Bot8.UseVisualStyleBackColor = True
        '
        'Bot9
        '
        Me.Bot9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot9.Location = New System.Drawing.Point(124, 156)
        Me.Bot9.Name = "Bot9"
        Me.Bot9.Size = New System.Drawing.Size(50, 50)
        Me.Bot9.TabIndex = 15
        Me.Bot9.Text = "9"
        Me.Bot9.UseVisualStyleBackColor = True
        '
        'BotBackspace
        '
        Me.BotBackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBackspace.Location = New System.Drawing.Point(12, 324)
        Me.BotBackspace.Name = "BotBackspace"
        Me.BotBackspace.Size = New System.Drawing.Size(50, 50)
        Me.BotBackspace.TabIndex = 16
        Me.BotBackspace.Text = "⌫"
        Me.BotBackspace.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(-1, 50)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ReadOnly = True
        Me.Resultado.Size = New System.Drawing.Size(231, 44)
        Me.Resultado.TabIndex = 17
        Me.Resultado.Text = "0"
        Me.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNum1
        '
        Me.TxtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum1.Location = New System.Drawing.Point(-1, 0)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.ReadOnly = True
        Me.TxtNum1.Size = New System.Drawing.Size(186, 44)
        Me.TxtNum1.TabIndex = 18
        Me.TxtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOp
        '
        Me.TxtOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOp.Location = New System.Drawing.Point(191, 0)
        Me.TxtOp.Name = "TxtOp"
        Me.TxtOp.ReadOnly = True
        Me.TxtOp.Size = New System.Drawing.Size(39, 44)
        Me.TxtOp.TabIndex = 19
        Me.TxtOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'botPonto
        '
        Me.botPonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botPonto.Location = New System.Drawing.Point(124, 324)
        Me.botPonto.Name = "botPonto"
        Me.botPonto.Size = New System.Drawing.Size(50, 50)
        Me.botPonto.TabIndex = 20
        Me.botPonto.Text = "."
        Me.botPonto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botPonto.UseVisualStyleBackColor = True
        '
        'BotClean
        '
        Me.BotClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotClean.Location = New System.Drawing.Point(12, 100)
        Me.BotClean.Name = "BotClean"
        Me.BotClean.Size = New System.Drawing.Size(50, 50)
        Me.BotClean.TabIndex = 21
        Me.BotClean.Text = "C"
        Me.BotClean.UseVisualStyleBackColor = True
        '
        'botInverter
        '
        Me.botInverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botInverter.Location = New System.Drawing.Point(124, 100)
        Me.botInverter.Name = "botInverter"
        Me.botInverter.Size = New System.Drawing.Size(50, 50)
        Me.botInverter.TabIndex = 22
        Me.botInverter.Text = "+/-"
        Me.botInverter.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 385)
        Me.Controls.Add(Me.botInverter)
        Me.Controls.Add(Me.BotClean)
        Me.Controls.Add(Me.botPonto)
        Me.Controls.Add(Me.TxtOp)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.BotBackspace)
        Me.Controls.Add(Me.Bot9)
        Me.Controls.Add(Me.Bot8)
        Me.Controls.Add(Me.Bot7)
        Me.Controls.Add(Me.BotSubtrair)
        Me.Controls.Add(Me.Bot6)
        Me.Controls.Add(Me.Bot5)
        Me.Controls.Add(Me.Bot4)
        Me.Controls.Add(Me.BotSomar)
        Me.Controls.Add(Me.Bot3)
        Me.Controls.Add(Me.Bot2)
        Me.Controls.Add(Me.Bot1)
        Me.Controls.Add(Me.BotCalcular)
        Me.Controls.Add(Me.BotMultiplicar)
        Me.Controls.Add(Me.Bot0)
        Me.Controls.Add(Me.BotDividir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotDividir As Button
    Friend WithEvents Bot0 As Button
    Friend WithEvents BotMultiplicar As Button
    Friend WithEvents BotCalcular As Button
    Friend WithEvents Bot1 As Button
    Friend WithEvents Bot2 As Button
    Friend WithEvents Bot3 As Button
    Friend WithEvents BotSomar As Button
    Friend WithEvents Bot4 As Button
    Friend WithEvents Bot5 As Button
    Friend WithEvents Bot6 As Button
    Friend WithEvents BotSubtrair As Button
    Friend WithEvents Bot7 As Button
    Friend WithEvents Bot8 As Button
    Friend WithEvents Bot9 As Button
    Friend WithEvents BotBackspace As Button
    Friend WithEvents Resultado As TextBox
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtOp As TextBox
    Friend WithEvents botPonto As Button
    Friend WithEvents BotClean As Button
    Friend WithEvents botInverter As Button
End Class
