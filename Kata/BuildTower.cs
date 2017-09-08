namespace Kata
{
    public class BuildTower
    {
        public string[] TowerBuilder(int nFloors)
        {
            string[] towerList = new string[nFloors];

            for (int i = nFloors; i > 0; i--)
            {
                towerList[nFloors - i] = getSpace(i) + getStar(i,nFloors) + getSpace(i);
            }

            return towerList;
        }

        private string getStar(int number, int floor)
        {
            string result = "*";

            for (int i = floor; i > number; i--) result = result + "**";

            return result;
        }

        private string getSpace(int number)
        {
            string result = "";

            for (int i = number; i > 1; i--) result = result + " ";

            return result;
        }
    }
}
