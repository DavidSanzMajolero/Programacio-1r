/*“És més eficient declarar una interfície només amb atributs de manera que la puguin implementar un conjunt de 
 classes o és millor pràctica declarar tots aquests atributs dins la classe abstracta encara que no totes les subclasses requereixin d’aquests atributs?” 
 Investiga sobre aquest tema i expon la teva conclusió. Indica les referències en què t’has basat. 

 
 
Com que normalment les interficies són per heretar compartaments (mètodes) a diferents clases que no tenen perque
tenir relacions entre elles, y les abstractes si que pretenen proporcionar una estructura comuna i compartida per a
diverses classes relacionades. La meva conclusió es que, és més eficient utilitzar una clase abstracta per heretar els
atributs y utilitzar només els que requereixi la subclase, en el cas de que totes les aquestes subclases estinguin
relacionats d'alguna manera lògica, i si són subclases totalment diferents, que no tenen res a veure, llavors diria que
utilitzar una interfície es millor.
 */