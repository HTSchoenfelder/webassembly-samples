mod utils;

use wasm_bindgen::prelude::*;

#[wasm_bindgen]
extern "C" {
    fn alert(s: &str);
}

#[wasm_bindgen]
pub fn greet() {
    alert("Bin da! Gruß Wasm!");
}

#[wasm_bindgen]
pub fn get_answer() -> i32 {
    42
}