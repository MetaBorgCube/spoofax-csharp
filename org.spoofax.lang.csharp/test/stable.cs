namespace StableURIs {
  
  class Foo {

    void bar() {
   
      int i;
      int j;
       
      if (true) {
      
        int i = i;
        int j = i;
        int k = j;
      
      } else {
      
        int i = i;
        int j = i;
      }
      
      for(int i=i; i<j; i=i+1;) {
        int i=i+i;
        int j=j;
      }
      
      int[] k;
      foreach(int i in k) {
        int i = i;
      } 
    }
  }
  
  class Foo {}
  
  class Foo {}
}