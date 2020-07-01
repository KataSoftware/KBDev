
    export class BooleanNullable {
        Value?: string;
        Text?: string;

        public static GetOptions(): Array<BooleanNullable> {
            let result: Array<BooleanNullable> = new Array<BooleanNullable>();
            result.push( { Value: "null", Text: "No establecido" });
            result.push( { Value: "true", Text: "Si" });
            result.push( { Value: "false", Text: "No" });
            
            return result;
        }

        public static BooleanToOption(value?:boolean): string {
            let result = new BooleanNullable();
            if (value == null ){
                
                result.Text = "No establecido";
                result.Value = "null";
            }else if (value == false){
                result.Text = "No";
                result.Value = "false";
            }else if (value == true){
                result.Text = "Si";
                result.Value = "true";
            }

            return result.Value;
        }
        public static OptionToBoolean(value?:any): any {
            let result:any = null;
            if (value == "true"){
                result = true;
            }else if (value == "false"){
                result = false;
            }

            return result;
        }

    }
