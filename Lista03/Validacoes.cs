public static class Validacoes
{
    public static bool ValidaCPF (string cpf)
    {
        // Remover pontos e traços do CPF
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Verificar se o CPF possui 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Calcular o primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i <9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }
        int primeiroDigitoVerificador = 11 - (soma % 11);
        if(primeiroDigitoVerificador >= 10)
        {
            primeiroDigitoVerificador = 0;
        }

        // Verificar se o primeio dígito verificador é igual ao do cálculo
        if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador)
        {
            return false;
        }

        // Calcular o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }
        int segundoDigitoVerificador = 11 - (soma % 11);
        if (segundoDigitoVerificador > 10)
        {
            segundoDigitoVerificador = 0;
        }

        // Verificar se o segundo dígito verificador é igual ao do cálculo
        if (int.Parse(cpf[10].ToString()) != segundoDigitoVerificador)
        {
            return false;
        }
        return true;
    }
}