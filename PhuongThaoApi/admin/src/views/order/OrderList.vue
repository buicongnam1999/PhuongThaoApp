<template>
    <div class="order">
        <header-basic>Danh sách Giao hàng</header-basic>
        <div class="order-header-function">
            <input-search />
            <button-refresh />
        </div>
    </div>
</template>

<script>
import HeaderBasic from "../../components/basic/HeaderBasic.vue"
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'

export default 
{
    components: { 
        HeaderBasic,
        InputSearch,
        ButtonRefresh 
    },
}
</script>

<style scoped>
.order-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>