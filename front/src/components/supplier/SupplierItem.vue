<template>
    <div class="item-supplier">
        <div class="supplier-numbers">
        <div>
            <span>CNPJ: </span><slot name="cnpj"></slot>
        </div>
        <div>
            <span>Registro: </span><slot name="stateRegi"></slot>
        </div>
        </div>
        
        <div class="details">
        <span>Ramo: </span> <slot name="ramo"></slot>
        </div>
    </div>
</template>
  
  <style lang="scss">
    .item-supplier {
      width: 60%;
      margin-top: 2rem;
      display: flex;
      align-items: baseline;
      position: relative;
      flex-direction: column;
      background-color: #888;
      color: #000;
      border: 1px solid;
      border-radius: 0.5rem;
      padding: 1rem;
  
      .supplier-numbers {
        display: flex;
  
        div {
          margin-right: 1rem;
          span {
            font-weight: 600;
          }
        }
      }
  
      .details {
        flex: 1;
        margin-left: 1rem;
  
        span {
            font-weight: 600;
        }
      }
    }
  </style>
  