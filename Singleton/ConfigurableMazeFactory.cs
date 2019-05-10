using System;
using Core;

namespace Singleton
{
    class ConfigurableMazeFactory
    {
        static MazeFactory instance;

        ConfigurableMazeFactory() { }
        
        public static MazeFactory Instance
        {
            get
            {
                if (AreYouTheKurgan())
                {
                    instance = new BombedMazeFactory();
                }
                else if (AreYouConnorMacLeod())
                {
                    instance = new EnchantedMazeFactory();
                }
                else
                {
                    instance = new NormalMazeFactory();
                }
                return instance;
            }
        }

        private static bool AreYouTheKurgan() => false;
        
        private static bool AreYouConnorMacLeod() => true;

        class BombedMazeFactory : MazeFactory
        {
            public Maze MakeMaze() => throw new NotImplementedException();

            public Room MakeRoom(int roomNumber) => throw new NotImplementedException();

            public Door MakeDoor(Room adjoiningRoom1, Room adjoiningRoom2) => throw new NotImplementedException();

            public Wall MakeWall() => throw new NotImplementedException();
        }
        
        class EnchantedMazeFactory : MazeFactory
        {
            public Maze MakeMaze() => throw new NotImplementedException();

            public Room MakeRoom(int roomNumber) => throw new NotImplementedException();

            public Door MakeDoor(Room adjoiningRoom1, Room adjoiningRoom2) => throw new NotImplementedException();

            public Wall MakeWall() => throw new NotImplementedException();
        }
        
        class NormalMazeFactory : MazeFactory
        {
            public Maze MakeMaze() => throw new NotImplementedException();

            public Room MakeRoom(int roomNumber) => throw new NotImplementedException();

            public Door MakeDoor(Room adjoiningRoom1, Room adjoiningRoom2) => throw new NotImplementedException();

            public Wall MakeWall() => throw new NotImplementedException();
        }
    }
}