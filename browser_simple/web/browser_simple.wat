(module
  (type (;0;) (func (result i32)))
  (type (;1;) (func))
  (func $get_calculated_value (type 0) (result i32)
    i32.const 815)
  (func $dummy (type 1))
  (func $__wasm_call_dtors (type 1)
    call $dummy
    call $dummy)
  (func $get_calculated_value.command_export (type 0) (result i32)
    call $get_calculated_value
    call $__wasm_call_dtors)
  (table (;0;) 1 1 funcref)
  (memory (;0;) 16)
  (global $__stack_pointer (mut i32) (i32.const 1048576))
  (export "memory" (memory 0))
  (export "get_calculated_value" (func $get_calculated_value.command_export)))
