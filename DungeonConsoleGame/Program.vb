Imports System

Module Program
    Public Class ItemStack
        Public Property Itemname As String

        Public Property Amount As Integer



    End Class




    Sub Main(args As String())

        Console.WriteLine("DungeonConsoleGame has economy and RPG features like dungeons, gambling, lootboxes, and PvP! ")
        Console.WriteLine("To get started type DCG")


        Dim Player As String  'Player is the person who will be typing in commands in console.'
        Dim Level As Integer  'Level is your skill in general.'
        Dim DungeonEnter As String   'Command to enter a dungeon.'
        Dim EnterPromisedLand As String  'Command to enter the gods lnd.'
        Dim Health As Integer
        Dim Inventory(6) As ItemStack

        If Console.ReadLine() = "DCG" Then
            Console.WriteLine("Here are all the commands you can use: ")
            Console.Write("Heal,")
            Console.Write("Fight,")
            Console.Write("Shop,")
            Console.Write("Buy,")
            Console.Write("Sell,")
            Console.Write("Dungeon,")
            Console.Write("adventure,")
            Console.WriteLine("Before every command type DCG then press space.")
        End If

        If Level < 5 Then
            Console.WriteLine("The basic shop") 'The shop that everyone starts out with.'
            Console.Write("Life potion")  'The Life potion will heal you the player for 10hp.'
            Console.Write("Basic armor")  'Basic armor will protect you from the basic enemies you would enconter when you use the command Hunt or Adventure.'
            Console.Write("Basic sword")  'Basic sword will help you defeate enemies you enconter when you use the command Hunt or Adventure.'
            Console.Write("Basic horse")  'The basic hourse can get you out of sticky situations.'
            Console.Write("Dungeon key 1") 'The key is needed to get into a dungeon'
        End If

        If Level > 5 Then
            Console.WriteLine("The skillful shop") 'The shop unlocked when you the player is above level 5. Which is an upgraded version of the basic shop.'
            Console.Write("Life potion")  'The Life potion will heal you the player for 25hp.'
            Console.Write("Iron armor")  'Skillful armor will protect you from beasts you would enconter when you use the commands Hunt, DungeonEnter or Adventure.'
            Console.Write("Stone sword")  'Stone sword will help you defeate stronger enemies you enconter when you use the command Hunt, DungeonEnter or Adventure.'
            Console.Write("Fast horse")  'The basic hourse can get you out of sticky situations.'
            Console.Write("Dungeon key 2") 'The key is needed to get into a dungeon.'
        End If

        If Level > 10 Then
            Console.WriteLine("The overpowerd player shop") 'The shop unlocked when you the player is above level 10. Which is an upgraded version of the skillful shop.'
            Console.Write("Life potion")  'The Life potion will heal you the player for 50hp.'
            Console.Write("Iron armor +")  'overpowerd armor will protect you from strong beasts you would enconter when you use the commands Hunt, DungeonEnter or Adventure.'
            Console.Write("Iron sword")  'Basic sword will help you defeate demonic enemies you enconter when you use the command Hunt, DungeonEnter or Adventure.'
            Console.Write("Speedy horse")  'The basic hourse can get you out of sticky situations.'
            Console.Write("Dungeon key 3") 'The key is needed to get into a dungeon.'
        End If

        If Level > 20 Then
            Console.WriteLine("MYTHIC SHOP") 'The shop unlocked when you the player is above level 20. Which is an upgraded version of the overpowerd shop.'
            Console.Write("Life potion")  'The Life potion will heal you the player for 70hp.'
            Console.Write("Scale armor")  'MYTHIC armor will protect you from infections when you use the commands Hunt, DungeonEnter or Adventure.'
            Console.Write("Scale sword")  'MYTHIC sword will help you defeate mutation you enconter when you use the command Hunt, DungeonEnter or Adventure.'
            Console.Write("Cerberus")  'The dog with three heads, it can attack and pick you up to take you to a safe location.'
            Console.Write("Dungeon key 4") 'The key is needed to get into a dungeon.'
        End If

        If Level > 50 Then
            Console.WriteLine("Legendary shop") 'The shop unlocked when you the player is above level 50. Which is an upgraded version of the MYTHIC shop.'
            Console.Write("Life potion")  'The Life potion will heal you the player from any percent of health to the max amount of health you have.'
            Console.Write("Achilles armor")  'Legendary armor will protect you from magic attacks you would enconter when you use the commands Hunt, DungeonEnter or Adventure.'
            Console.Write("Excalibur and Durandal swords")  'Legendary swords will help you defeate GODS you enconter when you use the EnterPromisedLand.'
            Console.Write("Dragon or Pheonix")  'The Legendary Dragon and Pheonix can set enemies a flame whilest taking you out of the heat.'
            Console.Write("Dungeon key 5") 'The key is needed to get into a dungeon.'
        End If

        'The armor you use that defends you from a specific creature or attack when you upgrade your armor the defence combine.'
        'The sword you use that helps defeat specific enemies when upgraded the abilities combine.'

        If Player = Console.ReadLine("DungeonEnter") Then




        End If


        If Player = Console.ReadLine("EnterPromisedLand") Then




        End If











    End Sub
End Module
