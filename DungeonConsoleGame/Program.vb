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
        Dim Experience As Integer
        Dim Coins As Integer


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

            If Experience = 50 Then
                Level = 1
            End If

            If Experience = 100 Then
                Level = 2
            End If

            If Experience = 150 Then
                Level = 3
            End If

            If Experience = 200 Then
                Level = 4
            End If

            If Experience = 250 Then
                Level = 5
            End If

            If Experience = 500 Then
                Level = 6
            End If

            If Experience = 550 Then
                Level = 7
            End If

            If Experience = 600 Then
                Level = 8
            End If

            If Experience = 700 Then
                Level = 9
            End If

            If Experience = 750 Then
                Level = 10
            End If

            If Experience = 800 Then
                Level = 11
            End If

            If Experience = 900 Then
                Level = 12
            End If

            If Experience = 1000 Then
                Level = 13
            End If

            If Experience = 1100 Then
                Level = 14
            End If

            If Experience = 1200 Then
                Level = 15
            End If

            If Experience = 1300 Then
                Level = 16
            End If

            If Experience = 1400 Then
                Level = 17
            End If

            If Experience = 1500 Then
                Level = 18
            End If

            If Experience = 1600 Then
                Level = 19
            End If

            If Experience = 1700 Then
                Level = 20
            End If

            If Experience = 1800 Then
                Level = 21
            End If

            If Experience = 1900 Then
                Level = 22
            End If

            If Experience = 2000 Then
                Level = 23
            End If

            If Experience = 2100 Then
                Level = 24
            End If

            If Experience = 2200 Then
                Level = 25
            End If

            If Experience = 2400 Then
                Level = 26
            End If

            If Experience = 2600 Then
                Level = 27
            End If

            If Experience = 2800 Then
                Level = 28
            End If

            If Experience = 3000 Then
                Level = 29
            End If

            If Experience = 3200 Then
                Level = 30
            End If

            If Experience = 3400 Then
                Level = 31
            End If

            If Experience = 3600 Then
                Level = 32
            End If

            If Experience = 3800 Then
                Level = 33
            End If

            If Experience = 4000 Then
                Level = 34
            End If

            If Experience = 4200 Then
                Level = 35
            End If

            If Experience = 4400 Then
                Level = 36
            End If

            If Experience = 4600 Then
                Level = 37
            End If

            If Experience = 4800 Then
                Level = 38
            End If

            If Experience = 5000 Then
                Level = 39
            End If

            If Experience = 5200 Then
                Level = 40
            End If

            If Experience = 5400 Then
                Level = 41
            End If

            If Experience = 5600 Then
                Level = 42
            End If

            If Experience = 5800 Then
                Level = 43
            End If

            If Experience = 6000 Then
                Level = 44
            End If

            If Experience = 6500 Then
                Level = 45
            End If

            If Experience = 7000 Then
                Level = 46
            End If

            If Experience = 7500 Then
                Level = 47
            End If

            If Experience = 8500 Then
                Level = 48
            End If

            If Experience = 9000 Then
                Level = 49
            End If

            If Experience = 10000 Then
                Level = 50
            End If

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

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If
                        End If

                            If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +8 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If

                        If MyValue = 3 Then
                            Experience = +11 And Coins = +5
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +5 And Coins = +5
                        End If
                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 10hp.")

                            If MyValue = 1 Then
                                Experience = +5 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +7 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 25hp.")
                            If MyValue = 3 Then
                                Experience = +10 And Coins = +5
                            End If
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +4 And Coins = +5
                        End If
                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 10hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +8 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If

                        If MyValue = 3 Then
                            Experience = +11 And Coins = +5
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +5 And Coins = +5
                        End If
                    End If

                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +8 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 5hp.")

                            If MyValue = 1 Then
                                Experience = +10 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +13 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 5hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If
                End If

                If Level > 30 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 145hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 45 hits to kill it, you took 145hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 17 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 64 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 24 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If



                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 120hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 160hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 120hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 160hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If


                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 105hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 5 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 57 hits to kill it, you took 140hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 105hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 140hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 55 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 58 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If




                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 55hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 40hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 80hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 55hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 40hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 80hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                End If

            End If

            If Console.ReadLine() = "Hunt" Then


                If Level < 10 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 10hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +8 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If

                        If MyValue = 3 Then
                            Experience = +11 And Coins = +5
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +5 And Coins = +5
                        End If
                    End If


                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 10hp.")

                            If MyValue = 1 Then
                                Experience = +5 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +7 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 25hp.")
                            If MyValue = 3 Then
                                Experience = +10 And Coins = +5
                            End If
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +4 And Coins = +5
                        End If
                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 4 hits to kill it, you took 10hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If
                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 4 hits to kill it, you took 15hp.")

                            If MyValue = 2 Then
                                Experience = +8 And Coins = +5
                            End If
                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 4 hits to kill it, you took 25hp.")
                        End If

                        If MyValue = 3 Then
                            Experience = +11 And Coins = +5
                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a baby rat, it took you 3 hits to kill it, you took 20hp.")
                        End If

                        If MyValue = 4 Then
                            Experience = +5 And Coins = +5
                        End If
                    End If

                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +8 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 5hp.")

                            If MyValue = 1 Then
                                Experience = +10 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +13 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 5hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 3 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 3 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 3 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 5 hits to kill it, you took 0hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a lost wolf, it took you 1 hits to kill it, you took 15hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a goblin, it took you 1 hits to kill it, you took 20hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a large rat, it took you 1 hits to kill it, you took 30hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If
                    End If
                End If

                If Level > 30 Then
                    If Contains("Basic sword", Inventory) And Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 145hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Basic armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 45 hits to kill it, you took 145hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 180hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Basic sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 17 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 64 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 24 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If



                    If Contains("Stone sword", Inventory) And Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 120hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 160hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Iron armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 120hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 170hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 160hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Stone sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 38 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 15 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 62 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If


                    If Contains("Scale sword", Inventory) And Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 105hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 5 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 57 hits to kill it, you took 140hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Scale armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 105hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 140hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 130hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Scale sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 18 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 55 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 58 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 22 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If




                    If Contains("Excalibur sword", Inventory) And Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 55hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 40hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 80hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Achilles armor", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 43 hits to kill it, you took 55hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 20 hits to kill it, you took 40hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 67 hits to kill it, you took 90hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 27 hits to kill it, you took 80hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                    End If

                    If Contains("Excalibur sword", Inventory) Then
                        If MyValue = 1 Then
                            Console.WriteLine("You encotered a armored oger, it took you 6 hits to kill it, you took 150hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 2 Then
                            Console.WriteLine("You encotered a armored knight, it took you 43 hits to kill it, you took 135hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 3 Then
                            Console.WriteLine("You encotered a armored titan, it took you 46 hits to kill it, you took 185hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

                        End If

                        If MyValue = 4 Then
                            Console.WriteLine("You encotered a demon wolf, it took you 10 hits to kill it, you took 175hp.")

                            If MyValue = 1 Then
                                Experience = +6 And Coins = +5
                            End If

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
