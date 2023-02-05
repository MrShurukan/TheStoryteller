module TheStorytellerCompiler.StoryLang

type StoryExpression =
    // Базовые выражения
    | VersionLiteral of string          // v1
    // Выражение как части объектов
    | AltLiteral of string              // | Альтернативное название
    | DescriptionLiteral of string      // "Описание объектов"
    
type ButtonModifier = 
    | Held

type WhenButtonStatementType =
    | Held
    | Pressed
    | Dropped

type WhenButtonStatement = WhenButtonStatementType * string

type Button = {
    Id: string
    Alt: string
    Description: string
    Modifiers: ButtonModifier list
    WhenBlock: WhenButtonStatement list
}

type DoorModifier =
    | Open
    | Closed

type Door = {
    Id: string
    Alt: string
    Description: string
    Modifiers: DoorModifier list
}
    
type Room = {
    Id: string
    Alt: string
    Description: string
    Buttons: Button list
    Doors: Door list
}

type Story = {
    Version: string
    Rooms: Room list
}
