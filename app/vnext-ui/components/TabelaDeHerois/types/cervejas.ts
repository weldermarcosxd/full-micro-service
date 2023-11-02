export interface Cerveja {
    id: number
    name: string
    tagline: string
    first_brewed: string
    description: string
    image_url: string
    abv: number
    ibu: number
    target_fg: number
    target_og: number
    ebc: number
    srm: number
    ph: number
    attenuation_level: number
    volume: Volume
    boil_volume: BoilVolume
    method: Method
    ingredients: Ingredients
    food_pairing: string[]
    brewers_tips: string
    contributed_by: string
  }
  
  export interface Volume {
    value: number
    unit: string
  }
  
  export interface BoilVolume {
    value: number
    unit: string
  }
  
  export interface Method {
    mash_temp: MashTemp[]
    fermentation: Fermentation
    twist: any
  }
  
  export interface MashTemp {
    temp: Temperatura
    duration: number
  }
  
  export interface Temperatura {
    value: number
    unit: string
  }
  
  export interface Fermentation {
    temp: Temperatura
  }
  
  export interface Ingredients {
    malt: Malt[]
    hops: Hop[]
    yeast: string
  }
  
  export interface Malt {
    name: string
    amount: Quantidade
  }
  
  export interface Hop {
    name: string
    amount: Quantidade
    add: string
    attribute: string
  }
  
  export interface Quantidade {
    value: number
    unit: string
  }