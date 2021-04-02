Imports System

Module Program
    Public Class ItemStack
        Public Property Itemname As String

        Public Property Amount As Integer

        Public Sub New(ByVal name As String, ByVal Amount1 As Integer)
            Itemname = name
            Amount = Amount1
        End Sub

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

        While True

            If Console.ReadLine() = "DCG" Then
                Console.WriteLine("Here are all the commands you can use: ")
                Console.Write("Heal,")
                Console.Write("Fight,")
                Console.Write("Shop,")
                Console.Write("Buy,")
                Console.Write("Sell,")
                Console.Write("Dungeon,")
                Console.Write("Adventure,")
                Console.WriteLine("Before every command type DCG then press space.")
            End If

            If Console.ReadLine() = "Shop" Then
                If Level < 5 Then
                    Console.WriteLine("The basic shop")        'The shop that everyone starts out with.'
                    Console.Write("Life potion,")          'The Life potion will heal you the player for 10hp.'
                    Console.Write("Basic armor,")          'Basic armor will protect you from the basic enemies you would enconter when you use the command Hunt or Adventure.'
                    Console.Write("Basic sword,")          'Basic sword will help you defeate enemies you enconter when you use the command Hunt or Adventure.'
                    Console.Write("Basic horse,")          'The basic hourse can get you out of sticky situations.'
                    Console.WriteLine("Dungeon key 1.")    'The key is needed to get into a dungeon'
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

                If Level > 30 Then
                    Console.WriteLine("Legendary shop") 'The shop unlocked when you the player is above level 50. Which is an upgraded version of the MYTHIC shop.'
                    Console.Write("Life potion")  'The Life potion will heal you the player from any percent of health to the max amount of health you have.'
                    Console.Write("Achilles armor")  'Legendary armor will protect you from magic attacks you would enconter when you use the commands Hunt, DungeonEnter or Adventure.'
                    Console.Write("Excalibur and Durandal swords")  'Legendary swords will help you defeate GODS you enconter when you use the EnterPromisedLand.'
                    Console.Write("Dragon or Pheonix")  'The Legendary Dragon and Pheonix can set enemies a flame whilest taking you out of the heat.'
                    Console.Write("Dungeon key 5") 'The key is needed to get into a dungeon.'
                End If

            End If
            'The armor you use that defends you from a specific creature or attack when you upgrade your armor the defence combine.'
            'The sword you use that helps defeat specific enemies when upgraded the abilities combine.'

            If Level < 5 Then
                If Console.ReadLine() = "Buy Life potion" Then
                    Inventory(0) = New ItemStack("Life potion", 5)
                End If

                If Console.ReadLine() = "Buy Basic armor" Then
                    Inventory(1) = New ItemStack("Basic armor", 1)
                End If

                If Console.ReadLine() = "Buy Basic sword" Then
                    Inventory(2) = New ItemStack("Basic sword", 1)
                End If

                If Console.ReadLine() = "Buy Basic horse" Then
                    Inventory(3) = New ItemStack("Basic horse", 1)
                End If

                If Console.ReadLine() = "Buy Dungeon key 1" Then
                    Inventory(4) = New ItemStack("Dungeon key 1", 1)
                End If
            End If

            If Level > 5 Then
                If Console.ReadLine() = "Buy Iron armor" Then
                    Inventory(1) = New ItemStack("Iron armor", 1)
                End If

                If Console.ReadLine() = "Buy Stone sword" Then
                    Inventory(2) = New ItemStack("Stone sword", 1)
                End If

                If Console.ReadLine() = "Buy Fast horse" Then
                    Inventory(3) = New ItemStack("Fast horse", 1)
                End If


                If Console.ReadLine() = "Buy Dungeon key 2" Then
                    Inventory(4) = New ItemStack("Dungeon key 2", 1)
                End If
            End If

            If Level > 10 Then
                If Console.ReadLine() = "Buy Iron armor" Then
                    Inventory(1) = New ItemStack("Iron armor", 1)
                End If

                If Console.ReadLine() = "Buy Iron sword" Then
                    Inventory(2) = New ItemStack("Iron sword", 1)
                End If

                If Console.ReadLine() = "Buy Speedy horse" Then
                    Inventory(3) = New ItemStack("Speedy horse", 1)
                End If


                If Console.ReadLine() = "Buy Dungeon key 3" Then
                    Inventory(4) = New ItemStack("Dungeon key 3", 1)
                End If
            End If

            If Level > 20 Then
                If Console.ReadLine() = "Buy Scale armor" Then
                    Inventory(1) = New ItemStack("Scale armor", 1)
                End If

                If Console.ReadLine() = "Buy Scale sword" Then
                    Inventory(2) = New ItemStack("Scale sword", 1)
                End If

                If Console.ReadLine() = "Buy Cerberus" Then
                    Inventory(3) = New ItemStack("Cerberus", 1)
                End If


                If Console.ReadLine() = "Buy Dungeon key 4" Then
                    Inventory(4) = New ItemStack("Dungeon key 4", 1)
                End If
            End If

            If Level > 30 Then
                If Console.ReadLine() = "Buy Achilles armor" Then
                    Inventory(1) = New ItemStack("Achilles armor", 1)
                End If

                If Console.ReadLine() = "Buy Excalibur sword" Then
                    Inventory(2) = New ItemStack("Excalibur sword", 1)
                End If

                If Console.ReadLine() = "Buy Durandal sword" Then
                    Inventory(2) = New ItemStack("Durandal sword", 1)
                End If

                If Console.ReadLine() = "Buy Dragon" Then
                    Inventory(3) = New ItemStack("Dragon", 1)
                End If

                If Console.ReadLine() = "Buy Pheonix" Then
                    Inventory(3) = New ItemStack("Pheonix", 1)
                End If

                If Console.ReadLine() = "Buy Dungeon key 5" Then
                    Inventory(4) = New ItemStack("Dungeon key 5", 1)
                End If
            End If



            Dim MyValue As Integer

            MyValue = Int((4 * Rnd()) + 1)

            If Console.ReadLine() = "Adventure" Then
                If Level < 10 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 10hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If
                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 10hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 25hp.")
                        End If
                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 5hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 15hp.")
                        End If
                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 5hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 15hp.")
                        End If
                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")
                        End If
                    End If
                End If

                If Level > 30 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 145hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")
                        End If

                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 45 hits to kill it, you took 145hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")
                        End If

                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 17 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 64 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 24 hits to kill it, you took 175hp.")
                        End If

                    End If



                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 120hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 170hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 160hp.")
                        End If

                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 120hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 170hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 160hp.")
                        End If

                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")
                        End If

                    End If


                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 105hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 5 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 57 hits to kill it, you took 140hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 130hp.")
                        End If

                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 105hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 140hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 130hp.")
                        End If

                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 55 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 58 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")
                        End If

                    End If




                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 55hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 40hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 80hp.")
                        End If

                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 55hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 40hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 80hp.")
                        End If

                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 175hp.")
                        End If

                    End If

                End If

            End If

            If Console.ReadLine() = "Hunt" Then
                If Level < 10 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 10hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If
                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 10hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 25hp.")
                        End If
                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 5hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 15hp.")
                        End If
                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 5hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 15hp.")
                        End If
                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")
                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")
                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")
                        End If
                    End If
                End If

                If Level > 30 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 145hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")
                        End If

                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 45 hits to kill it, you took 145hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")
                        End If

                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 17 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 64 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 24 hits to kill it, you took 175hp.")
                        End If

                    End If



                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 120hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 170hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 160hp.")
                        End If

                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 120hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 170hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 160hp.")
                        End If

                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")
                        End If

                    End If


                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 105hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 5 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 57 hits to kill it, you took 140hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 130hp.")
                        End If

                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 105hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 140hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 130hp.")
                        End If

                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 55 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 58 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")
                        End If

                    End If




                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 55hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 40hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 80hp.")
                        End If

                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 55hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 40hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 90hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 80hp.")
                        End If

                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 150hp.")
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 135hp.")
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 185hp.")
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 175hp.")
                        End If

                    End If

                End If

            End If








        End While


    End Sub

    Function Contains(name As String, Inventory As ItemStack()) As Boolean
        For I = 0 To Inventory.Length
            If Inventory(I).Itemname = name Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
