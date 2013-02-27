using Web;

namespace Web {
  partial class URL {
	  string GetLocation() {
	    return location; 
	  }
  }
}

namespace Blogger {
	class User { 
		string name; 
		URL homepage;
	}

	class BlogPosting {
		User poster;
		string body; 
		
		URL Homepage() {
		  return this.poster.homepage;
		}
		
		string HomepageString() {
		  URL url = Homepage();
			return url.GetLocation();
		}
		
		int Location() {
			//i = i;
			int i;
			i = i;
			for (int i = i; i <10 ; i = i + 1;) {
				
				i = i + 1;
			}
			
			foreach (int i in i) {
				i = i;
			}
			return i;
		}

		int factorial(int num) {
		  if(num <= 1) {
		    int fac = 1;
		    return fac;
		  }
		  
	    int fac = num * factorial(num - 1);
	    return fac;
		} 
	}
}