<template>
    <div class="product">
        <header-basic>Danh sách sản phẩm</header-basic>
        <div class="product-header-function">
            <input-search />
            <button-refresh />
        </div>
        <div class="product-table">
            <product-table />
        </div>
    </div>
</template>

<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
import ProductTable from '../../components/product/ProductTable.vue'
export default {
  components: { 
      HeaderBasic,
      InputSearch,
      ButtonRefresh,
      ProductTable
    },
    
}
</script>

<style scoped>
.product-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>