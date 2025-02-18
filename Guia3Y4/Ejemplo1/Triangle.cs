public  class Triangle : Shape3
{
    public double AreaTriangle { get; set; }
    override public double  Area(){
        AreaTriangle = 0.5*(Heigth*With);
        return AreaTriangle;
    }
    
}