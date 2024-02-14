# Versione Uno A Molti di Rubrica
Esempi di doppia grid per visualizzare una relazione uno a molti
```mermaid
erDiagram
    PERSONA ||--o{ CONTATTO : ha
    PERSONA {
        int idPersona PK
        string Nome
        string Cognome
    }
    CONTATTO {
        int idContatto PK
        TIPO Tipo
        string Valore
    }
    TIPO {
        string Telefono
        string Cellulare
        string EMail
        string Web
        string FB
        string X
        string Insta
    }
```

Questo schema è stato scritto usando la sintassi mermaid

https://mermaid.js.org/syntax/entityRelationshipDiagram.html

Lato persona i due trattini significano che un generico Contatto può essere associato ad una sola Persona

Lato Contatto la cosidetta zampa di gallina indica "Molti" come a dire che a una Persona posso associare molti contatti

Il pallino va letto come "Zero" e questo significa che una Persona potrebbe anche NON avere contatti

Ricapitolando, un "Persona" può avere da zero a molti "Contatto".
