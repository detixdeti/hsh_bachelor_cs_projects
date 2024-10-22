#include <cstring>
#include <cstdlib>
#include <iostream>
using namespace std;

class Ort {
private:
  double breite; // Breitengrad
  double laenge; // Laengengrad 
  double hoehe;  // Hoehe ueber NN in m
  char* name;    // Ortsname               // spaeter: std::string statt char[]
  void initName(const char* pname) {
    name= (char*)malloc(strlen(pname)+1);  
    // spaeter: new char[strlen(pname)+1] bzw. std::string statt char[] und ...
    strcpy(name, pname);  // ... dann hier Copy-Konstruktor von string benutzen
  }
public:
  double getBreite() { return breite; }
  double getLaenge() { return laenge; }
  double getHoehe() { return hoehe; }
  const char* getName() { return name; }
  Ort(double breite, double laenge, double hoehe, const char* name) { 
    this->breite= breite; this->laenge= laenge; this->hoehe= hoehe;
    initName(name); 
  }
  Ort(double breite, double laenge, const char* name) 
    // Alternativ mit Initialisierungsliste: breite {breite}, laenge {laenge} { 
  { 
    this->breite= breite; this->laenge= laenge; this->hoehe= 0.0;
    initName(name); 
  }
  Ort(const Ort &o) { 
    // cout << "Copy constructor invoked for " << o.name << endl;
    this->breite= o.breite; this->laenge= o.laenge; this->hoehe= o.hoehe;
    initName(o.name); 
  }
  ~Ort() { 
    free(name);  name = nullptr; // spaeter: Destruktor leer (faellt weg)
  }
  void print() {
    cout << name << " (" << breite << "�B, " << laenge << "�L, " << hoehe << " m �. NN)" << endl;
  }
};

int main() {
  Ort hannover {52.3667, 9.71667, 55.0, "Hannover"};
  Ort hannover2 {hannover};
  Ort rio {-22.9, -43.23333, 32.0, "Rio de Janeiro"};  
  hannover.print();
  hannover2.print();
  rio.print();
}
