﻿using Kumiko.Domain.Entities.Base;

namespace Kumiko.Domain.Entities;

public class ChecktTime : ModelBase //quitas interna y pones publica (nivel de acceso)
{
    public DateTime Check {  get; set; }    
}
