class Array
{
  void Learn1DArray()
  {
int[] ages1 = new int[10];
double[] ages2 = new double[10];

ages1[0]=21;
ages1[2]=2;

    float[] numbers = new float[]  {23.4f,23.32f,323.23f};
    float[] numbers1 =  {23.4f,23.32f,323.23f};
 }
   void LearnMulDArray()
  {
    //2D Array
    int[,] agesMatrix=new int[19,14];//2D array having 19 rows and 14 columns
    agesMatrix[0,0]=452;
    //3D Array
    int[,,] agesMatrix3D=new int[10,15,5];//3D array having 10 items and that items itself is a 2D array having 15 rows and 5 columns


string[,] names = new string[,] {{"Shankar","Khadka"}, {"Shubham","Khadka"}};
string[,] names1 = {{"Shankar","Khadka"}, {"Shubham","Khadka"}};
  } 

  //jagged array - jagged array contains the different numbers of rows elements in an array
  //having different row size
  //23,43,54,54
  //34,55,44
  //24,56,88,9
  // void LearnJaggedArray()
  // {
  //   byte[][] personAges = new byte[3][]; 
  //    personAges[0] = new byte[3]{23,43,54}; 
  //    personAges[1] = new byte[5]{234,56,76,45,25};
  //    personAges[2] = new byte[6]{234,56,76,45,25,34}; 
  //   // personAges[3] = new byte[]{234,56,76,45,25};
  //   }
}