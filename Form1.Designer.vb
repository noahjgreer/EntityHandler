<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntityHandler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntityHandler))
        Me.EntityHandlerHeaderLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.EntityHandlerHeaderLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntityHandlerHeaderLogo
        '
        Me.EntityHandlerHeaderLogo.BackColor = System.Drawing.Color.Transparent
        Me.EntityHandlerHeaderLogo.Image = CType(resources.GetObject("EntityHandlerHeaderLogo.Image"), System.Drawing.Image)
        Me.EntityHandlerHeaderLogo.Location = New System.Drawing.Point(12, 48)
        Me.EntityHandlerHeaderLogo.Name = "EntityHandlerHeaderLogo"
        Me.EntityHandlerHeaderLogo.Size = New System.Drawing.Size(256, 256)
        Me.EntityHandlerHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EntityHandlerHeaderLogo.TabIndex = 0
        Me.EntityHandlerHeaderLogo.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(71, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(274, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(834, 170)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EntityHandler"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(314, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "By: NJGminecraft"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1091, 347)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mob Builder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(469, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Base Entity: (This is what the AI runs off of)"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Area Effect Cloud", "Armor Stand", "Arrow", "Axolotl", "Bat", "Bee", "Blaze", "Boat", "Cat", "Cave Spider", "Minecart with Chest", "Chicken", "Cod", "Minecart with Command Block", "Cow", "Creeper", "Dolphin", "Donkey", "Dragon Fireball", "Drowned", "Egg", "Elder Guardian", "End Crystal", "Ender Dragon", "Ender Pearl", "Enderman", "Endermite", "Evoker", "Evoker Fangs", "Thrown Experience Bottle", "Experience Orb", "Eye of Ender", "Falling Block", "Fireball", "Firework Rocket", "Fox", "Minecart with Furnace", "Ghast", "Giant", "Glow Item Frame", "Glow Squid", "Goat", "Guardian", "Hogin", "Minecart with Hopper", "Horse", "Husk", "Illusioner", "Iron Golem", "Item", "Item Frame", "Lead", "Lightning Bolt", "Llama", "Llama Spit", "Magma Cube", "Marker", "Minecart", "Mooshroom", "Mule", "Ocelot", "Painting", "Panda", "Parrot", "Phantom", "Pig", "Piglin", "Piglin Brute", "Pillager", "Polar Bear", "Thrown Potion", "Pufferfish", "Rabbit", "Ravager", "Salmon", "Sheep", "Shulker", "Shulker Bullet", "Siverfish", "Skeleton", "Skeleton Horse", "Slime", "Small Fireball", "Snow Golem", "Snowball", "Minecart with Spawner", "Spectral Arrow", "Spider", "Squid", "Stray", "Strider", "TNT", "Minecart with TNT", "Trader Llama", "Trident", "Tropical Fish", "Turtle", "Vex", "Villager", "Vindicator", "Wandering Trader", "Witch", "Wither", "Wither Skeleton", "Wither Skull", "Wolf", "Zoglin", "Zombie", "Zombie Horse", "Zombie Villager", "Zombified Piglin"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(232, 40)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Custom Entity Name (No Spaces Please)"
        Me.TextBox1.Size = New System.Drawing.Size(1078, 39)
        Me.TextBox1.TabIndex = 0
        '
        'EntityHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EntityHandlerHeaderLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EntityHandler"
        Me.Text = "EntityHandler"
        CType(Me.EntityHandlerHeaderLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EntityHandlerHeaderLogo As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
