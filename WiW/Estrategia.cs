
using System;
using System.Collections.Generic;
using tp1;
using tp2;

namespace tpfinal
{

	class Estrategia
	{
		
//		Consulta1  (ArbolBinario<  DecisionData  >  arbol):  Retorna  un  texto  con  todas  las posibles predicciones 
//		que puede calcular el árbol de decisión del sistema.
		
		public String Consulta1(ArbolBinario<DecisionData> arbol)
		{
			string result="";
			
			if(arbol.esHoja())
			{
				result= (arbol.getDatoRaiz().ToString()) + "\n";
			}
			
			if(arbol.getHijoIzquierdo() != null)
			{
				result +=Consulta1(arbol.getHijoIzquierdo());
			}
			
			
			if(arbol.getHijoDerecho() != null)
			{
				result +=Consulta1(arbol.getHijoDerecho());
			}
			
			return result;
		}

//		Consulta2 (ArbolBinario< DecisionData > arbol): Retorna un texto que contiene todos los caminos hasta cada predicción.

		public String Consulta2(ArbolBinario<DecisionData> arbol)
		{
			List<ArbolBinario<DecisionData>> camino=new List<ArbolBinario<DecisionData>>();
				
			return Consulta2(arbol,camino);
			
		}
		
		private String Consulta2(ArbolBinario<DecisionData> arbol, List<ArbolBinario<DecisionData>> camino)
		{		
			string result="";
			camino.Add(arbol);
			
			if(arbol.esHoja())
			{			
				foreach(ArbolBinario<DecisionData> elemCamino in camino)
				{
					result += (elemCamino.getDatoRaiz().ToString()) + " | ";
				}
				
				result+="\n";
				
			}
			
			else{
				
				if(arbol.getHijoIzquierdo() != null)
				{
					result += Consulta2(arbol.getHijoIzquierdo(),camino);
					camino.RemoveAt(camino.Count-1);
				}
				if(arbol.getHijoDerecho() != null)
				{
					result += Consulta2(arbol.getHijoDerecho(),camino);
					camino.RemoveAt(camino.Count-1);
				}
			}
			
			return result;
		}

//		Consulta3 (ArbolBinario< DecisionData > arbol): Retorna un texto que contiene los datos  almacenados  en  los  nodos del  árbol
//		diferenciados por el nivel en  que  se encuentran.
		
		public String Consulta3(ArbolBinario<DecisionData> arbol)
		{	
			
			int nivel=0;
			string result=" Nivel " + nivel + ": ";	
			
			Cola<ArbolBinario<DecisionData>> c=new Cola <ArbolBinario<DecisionData>>();
			ArbolBinario <DecisionData> arbolAux;
		
			c.encolar(arbol);
			c.encolar(null); 
			
			while(!c.esVacia())
			{
				arbolAux=c.desencolar();
				
				if(arbolAux != null) 
				{
					result += arbolAux.getDatoRaiz().ToString();
					
					if(arbolAux.getHijoIzquierdo() != null)
					{
						c.encolar(arbolAux.getHijoIzquierdo());
					}
				
					if(arbolAux.getHijoDerecho() != null)
					{
						c.encolar(arbolAux.getHijoDerecho());
					}
				}
				
				else 
				{
					
					nivel ++;
					
					if(!c.esVacia())
					{
						result+="\n Nivel "+ nivel + ": ";
						c.encolar(null);
					}
					
				}
			}
			
			return result;
		}

		
//		CrearArbol (Clasificador clasificador): Este método construye un árbol de decisión a partir de un clasificador que es enviado como parámetro
//		y retorna una instancia de ArbolBinario<DecisionData>.
		
		public ArbolBinario<DecisionData> CrearArbol(Clasificador clasificador)
		{
			ArbolBinario<DecisionData> arbol;
			
            if(clasificador.crearHoja())
            {
                DecisionData prediccion=new DecisionData(clasificador.obtenerDatoHoja());
               	arbol= new ArbolBinario<DecisionData>(prediccion); //dato
  
            }
            
            else{
            
	            DecisionData pregunta= new DecisionData(clasificador.obtenerPregunta());  
	            arbol=new ArbolBinario<DecisionData>(pregunta); //dato
	            
	            arbol.agregarHijoIzquierdo(CrearArbol(clasificador.obtenerClasificadorIzquierdo())); //HI
	   
	            
	            arbol.agregarHijoDerecho(CrearArbol(clasificador.obtenerClasificadorDerecho())); //HD
            
            }
            
            return arbol;
			
		}
	}
}