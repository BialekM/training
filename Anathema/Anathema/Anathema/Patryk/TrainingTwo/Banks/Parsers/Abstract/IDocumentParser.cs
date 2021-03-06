﻿using System.Collections.Generic;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{
    public interface IDocumentParser<TResult>
    {
        List<TResult> GetAllResults(string path);

    }
}