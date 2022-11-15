# GenericPolynomial
A univariate, sparse, generic polynomial arithmetic library. That is, a polynomial in only one indeterminate, X, that only tracks terms with non-zero coefficients. This generic implementation has been tested and supports performing arithmetic on numeric types such as BigInteger, Complex, Decimal, Double, BigComplex, BigDecimal, BigRational, Int32, Int64 and more.

All arithmetic is done __symbolically__. That means the result a arithmetic operation on two polynomials, returns another polynomial, not some value type that is the result of evaluating said polynomials.

#


### Generic Arithmetic Type Polynomial

* All classes and methods support a generic type T, which can be any data type that has arithmetic operator overloads. Explicitily, the following types have tests excersizing all the standard arithmetic operations (Addition, Subtraction, Multiplication, Division, Exponentiation, Modulus, Square Root, Equality and Comparison (where applicable--Complex numbers are not orderable)) and so are well supported and come with verifiable proof that they work:
   * Every .NET value type (byte, Int16, Int32, Int64, UInt16/32/64, float, double)
   * Decimal
   * Complex
   * BigInteger
   * BigComplex (My arbitrary precision complex number arithmetic type library, [ExtendedNumerics.BigComplex](https://github.com/AdamWhiteHat/BigComplex))
   * BigDecimal (My arbitrary precision floating-point number arithmetic type library, [ExtendedNumerics.BigDecimal](https://github.com/AdamWhiteHat/BigDecimal))
   * BigRational(My arbitrary precision rational number arithmetic type library, [ExtendedNumerics.BigRational](https://github.com/AdamWhiteHat/BigRational))
   * Fraction   (My arbitrary precision rational number (as an improper fraction) arithmetic type library, [ExtendedNumerics.BigRational](https://github.com/AdamWhiteHat/BigRational))

 
* Supports **symbolic** univariate polynomial (generic) arithmetic including:
   * Addition
   * Subtraction
   * Multiplication
   * Division
   * Modulus
   * Exponentiation   
   * GCD of polynomials
   * Irreducibility checking
   * Polynomial evaluation by assigning to the invariant (X in this case) a value.

#


### Polynomial Rings over a Finite Field

* **Polynomial.Field** supports addition, multiplication, division/modulus and inverse of a polynomial ring over a finite field. These operations do not support Complex, BigComplex, BigDecimal, or BigRational types.
   * What this effectively means in less-technical terms is that the polynomial arithmetic is performed in the usual way, but the result is then taken modulus two things: A BigInteger integer and another polynomial:
      * Modulus an integer: All the polynomial coefficients are reduced modulus this integer.
      * Modulus a polynomial: The whole polynomial is reduced modulus another, smaller, polynomial. This notion works much the same as regular modulus; The modulus polynomial, lets call it g, is declared to be zero, and so every multiple of g is reduced to zero. You can think of it this way (although this is not how its actually carried out): From a large polynomial, g is repeatedly subtracted from that polynomial until it cant subtract g anymore without going past zero. The result is a polynomial that lies between 0 and g. Just like regular modulus, the result is always less than your modulus, or zero if the first polynomial was an exact multiple of the modulus.
      * Effectively forms a quotient ring
   
* You can instantiate a polynomial in various ways:
   * From a string
      * This is the most massively-useful way and is the quickest way to start working with a particular polynomial you had in mind.
   * From its roots (Not all types supported)
      * Build a polynomial that has as its roots, all of the numbers in the supplied array. If you want multiplicity of roots, include that number in the array multiple times.
   * From the base-m expansion of a number
      * Given a large number and a radix (base), call it m, a polynomial will be generated that is that number represented in the number base m.
   

* Other methods of interest that are related to, but not necessarily performed on a polynomial (Not all types supported):
   * Eulers Criterion
   * Legendre Symbol and Legendre Symbol Search
   * Tonelli-Shanks
   * Chinese Remainder Theorem
   


