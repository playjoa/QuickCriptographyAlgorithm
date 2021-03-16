public class Cripto
{
    string refKey = "abcdefghijklmnopqrstuvwxyzáàãâéèêíìîóòôõÁÀÂÃÉÈÊÍÌÎÓÒÕÔABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-= ,.!?#()"
    string criptoKey = ")(#?!.,=-9876543210ZYXWVUTSRQPONMLKJIHGFEDCBAÔÕÒÓÎÌÍÊÈÉÃÂÀÁõôòóîìíêèéâãàázyxwvutsrqponmlkjihgfedcba";


    string Decripto(string targetText)
    {
        if (targetText == string.Empty)
            return "";
        
        string outputText = "" ;

        for (int i = 0; i < targetText.Length; i++)
        {
            outputText += DecriptLetter(targetText[i]);
        }
        
        return outputText;
    }

    void Cripto(string targetText)
    {
        if (targetText == string.Empty)
            return "";
        
        string  outputText = "";

        for (int i = 0; i < targetText.Length; i++)
        {
            txtTextoCriptografado += CriptLetter(targetText[i]);
        }
        
        return outputText;
    }

    char CriptLetter(char curLetter)
    {
        int idInKey = -1;
        
        for (int i = 0; i < refKey.Length; i++)
        {
            if (refKey[i] == curLetter)
                idInKey = i;
        }

            if (idInKey == -1)
                return curLetter;
            else
                return criptoKey[idInKey];
    }

    char DecriptLetter(char curLetter)
    {
        int idInKey = -1;

        for (int i = 0; i < criptoKey.Length; i++)
        {
            if (criptoKey[i] == curLetter)
                idInKey = i;
        }

        if (idInKey == -1)
            return curLetter;
        else
            return refKey[idInKey]; 
    }
}